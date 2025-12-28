using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectR.Forms
{
    public partial class ReportsDashboard : UserControl
    {
        internal Form MainWindowF { get; set; }

        public ReportsDashboard()
        {
            InitializeComponent();
            this.SidebarData();
        }
        
        private string getData(string query)
        {
            string TotalProducts = "0";
            try
            {
                TotalProducts = MainWindow.SqlDataAccess.ExecuteQueryTable(query).Rows[0][0].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
            return TotalProducts;
        }

        private void getDataTable(string sql ,Label a, Label b, Label c)
        {
            try
            {
                var da = MainWindow.SqlDataAccess.ExecuteQueryTable(sql);
                a.Text += da.Rows[0][0].ToString();
                b.Text += da.Rows[0][1].ToString();
                c.Text += da.Rows[0][3].ToString() + " BDT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void SidebarData()
        {
            this.lblTotalProducts.Text = this.getData("select count(*) from ProductList;");
            this.lblOutOfStock.Text = this.getData("select count(*) from ProductList where ProductStock = 0;");
            this.lblTotalSells.Text = this.getData("select sum(TotalAmount) from TransactionList;");

            var a = new DataTable();
            string sql = $@"SELECT TOP 1 WITH TIES
                                td.ProductId,
                                pl.ProductName,
                                COUNT(td.ProductId) AS TransactionCount,
                                sum(td.Quantity*td.UnitPrice) as TotalPrice
                            FROM
                                TransactionDetails AS td,
                                ProductList AS pl where td.ProductId = pl.ProductId
                            GROUP BY
                                td.ProductId,
                                pl.ProductName
                            ORDER BY
                                TransactionCount DESC,TotalPrice DESC;";
            this.getDataTable(sql, lblProductId, lblProductName, lblProductSells);

            string sql2 = $@"SELECT TOP 1 WITH TIES
                                tl.SalesmanID,
                                ul.Username,
                                COUNT(tl.SalesmanID) AS TransactionCount,
                                sum(tl.TotalAmount) as TotalAmount
                            FROM
                                TransactionList AS tl,
                                UserList AS ul where tl.SalesmanID = ul.UserId
                            GROUP BY
                                tl.SalesmanID,
                                ul.Username
                            ORDER BY
                                TransactionCount DESC,TotalAmount DESC;";

            this.getDataTable(sql2, lblSellerID, lblSellerName, lblSellerTotalSell);
        }

        private void ReportsDashboard_Load(object sender, EventArgs e)
        {
            string[] monthsName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string query = $@"WITH Last4Months AS (
                                        SELECT TOP 4
                                            YEAR(TimeAndDate) AS Yr,
                                            MONTH(TimeAndDate) AS Mn
                                        FROM TransactionList
                                        GROUP BY YEAR(TimeAndDate), MONTH(TimeAndDate)
                                        ORDER BY YEAR(TimeAndDate) DESC, MONTH(TimeAndDate) DESC
                                    )
                                    SELECT
                                        l.Mn AS MonthNumber,
                                        SUM(t.TotalAmount) AS Total_Amount
                                    FROM Last4Months l
                                    JOIN TransactionList t
                                        ON YEAR(t.TimeAndDate) = l.Yr
                                        AND MONTH(t.TimeAndDate) = l.Mn
                                    GROUP BY l.Yr, l.Mn
                                    ORDER BY l.Yr DESC, l.Mn DESC;";
            try
            {
                var da = MainWindow.SqlDataAccess.ExecuteQueryTable(query);

                this.lblMonth1.Text = monthsName[Convert.ToInt32(da.Rows[3][0]) - 1];
                this.lblMonth2.Text = monthsName[Convert.ToInt32(da.Rows[2][0]) - 1];
                this.lblMonth3.Text = monthsName[Convert.ToInt32(da.Rows[1][0]) - 1];
                this.lblMonth4.Text = monthsName[Convert.ToInt32(da.Rows[0][0]) - 1];

                var SqlTotalSellsIn4M = $@"SELECT SUM(t.TotalAmount) AS Total_Amount
                                            FROM TransactionList t
                                            WHERE EXISTS (
                                                SELECT 1
                                                FROM (
                                                    SELECT TOP 4
                                                        YEAR(TimeAndDate) AS Yr,
                                                        MONTH(TimeAndDate) AS Mn
                                                    FROM TransactionList
                                                    GROUP BY YEAR(TimeAndDate), MONTH(TimeAndDate)
                                                    ORDER BY YEAR(TimeAndDate) DESC, MONTH(TimeAndDate) DESC
                                                ) m
                                                WHERE YEAR(t.TimeAndDate) = m.Yr
                                                  AND MONTH(t.TimeAndDate) = m.Mn
                                            );";

                double Month1Sells = Convert.ToInt32(da.Rows[0][1]);
                double Month2Sells = Convert.ToInt32(da.Rows[1][1]);
                double Month3Sells = Convert.ToInt32(da.Rows[2][1]);
                double Month4Sells = Convert.ToInt32(da.Rows[3][1]);

                this.lblMonthSells4.Text = Month1Sells.ToString();
                this.lblMonthSells3.Text = Month2Sells.ToString();
                this.lblMonthSells2.Text = Month3Sells.ToString();
                this.lblMonthSells1.Text = Month4Sells.ToString();
                double TotalSells = Convert.ToInt32(getData(SqlTotalSellsIn4M));

                double Month1bar = (Month1Sells / TotalSells) * 400;
                double Month2bar = (Month2Sells / TotalSells) * 400;
                double Month3bar = (Month3Sells / TotalSells) * 400;
                double Month4bar = (Month4Sells / TotalSells) * 400;

                this.pnlMonth4.Size = new System.Drawing.Size(64, Convert.ToInt32(Month1bar));
                this.pnlMonth3.Size = new System.Drawing.Size(64, Convert.ToInt32(Month2bar));
                this.pnlMonth2.Size = new System.Drawing.Size(64, Convert.ToInt32(Month3bar));
                this.pnlMonth1.Size = new System.Drawing.Size(64, Convert.ToInt32(Month4bar));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
