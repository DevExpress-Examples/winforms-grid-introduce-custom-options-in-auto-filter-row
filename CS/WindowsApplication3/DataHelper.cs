using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXSample
{
    class DataHelper
    {
        public static DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;
            table.Columns.Add("OrderID", typeof(System.Int32));
            table.Columns.Add("OrderDate", typeof(System.DateTime));
            table.Columns.Add("RequiredDate", typeof(System.DateTime));
            table.Columns.Add("ShipVia", typeof(System.Int32));
            table.Columns.Add("Freight", typeof(System.Decimal));
            table.Columns.Add("ShipCity", typeof(System.String));
            dataRow = table.NewRow();
            dataRow["OrderID"] = 10248;
            dataRow["OrderDate"] = DateTime.Parse("8/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 32.38;
            dataRow["ShipCity"] = "Reims";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10249;
            dataRow["OrderDate"] = DateTime.Parse("8/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 11.61;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10250;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 65.83;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10251;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 41.34;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10252;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 51.3;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10253;
            dataRow["OrderDate"] = DateTime.Parse("8/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.17;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10254;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 22.98;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10255;
            dataRow["OrderDate"] = DateTime.Parse("8/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/9/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 148.33;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10256;
            dataRow["OrderDate"] = DateTime.Parse("8/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/12/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.97;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10257;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/13/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 81.91;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10258;
            dataRow["OrderDate"] = DateTime.Parse("8/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 140.51;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10259;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.25;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10260;
            dataRow["OrderDate"] = DateTime.Parse("8/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 55.09;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10261;
            dataRow["OrderDate"] = DateTime.Parse("8/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.05;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10262;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 48.29;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10263;
            dataRow["OrderDate"] = DateTime.Parse("8/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/20/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 146.06;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10264;
            dataRow["OrderDate"] = DateTime.Parse("8/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/21/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.67;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10265;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 55.28;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10266;
            dataRow["OrderDate"] = DateTime.Parse("8/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 25.73;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10267;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 208.58;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10268;
            dataRow["OrderDate"] = DateTime.Parse("8/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 66.29;
            dataRow["ShipCity"] = "Caracas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10269;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.56;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10270;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 136.54;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10271;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.54;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10272;
            dataRow["OrderDate"] = DateTime.Parse("9/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/30/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 98.03;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10273;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 76.07;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10274;
            dataRow["OrderDate"] = DateTime.Parse("9/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/4/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 6.01;
            dataRow["ShipCity"] = "Reims";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10275;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 26.93;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10276;
            dataRow["OrderDate"] = DateTime.Parse("9/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 13.84;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10277;
            dataRow["OrderDate"] = DateTime.Parse("9/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 125.77;
            dataRow["ShipCity"] = "Leipzig";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10278;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 92.69;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10279;
            dataRow["OrderDate"] = DateTime.Parse("9/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.83;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10280;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.98;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10281;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.94;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10282;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.69;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10283;
            dataRow["OrderDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 84.81;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10284;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 76.56;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10285;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 76.83;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10286;
            dataRow["OrderDate"] = DateTime.Parse("9/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/19/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 229.24;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10287;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 12.76;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10288;
            dataRow["OrderDate"] = DateTime.Parse("9/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 7.45;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10289;
            dataRow["OrderDate"] = DateTime.Parse("9/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/24/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 22.77;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10290;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 79.7;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10291;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 6.4;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10292;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/26/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.35;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10293;
            dataRow["OrderDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 21.18;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10294;
            dataRow["OrderDate"] = DateTime.Parse("9/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/28/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 147.26;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10295;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.15;
            dataRow["ShipCity"] = "Reims";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10296;
            dataRow["OrderDate"] = DateTime.Parse("10/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.12;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10297;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 5.74;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10298;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 168.22;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10299;
            dataRow["OrderDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 29.76;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10300;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 17.68;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10301;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 45.08;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10302;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 6.27;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10303;
            dataRow["OrderDate"] = DateTime.Parse("10/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 107.83;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10304;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 63.79;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10305;
            dataRow["OrderDate"] = DateTime.Parse("10/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/11/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 257.62;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10306;
            dataRow["OrderDate"] = DateTime.Parse("10/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 7.56;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10307;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.56;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10308;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.61;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10309;
            dataRow["OrderDate"] = DateTime.Parse("10/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 47.3;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10310;
            dataRow["OrderDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/18/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 17.52;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10311;
            dataRow["OrderDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 24.69;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10312;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 40.26;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10313;
            dataRow["OrderDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/22/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.96;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10314;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 74.16;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10315;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 41.76;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10316;
            dataRow["OrderDate"] = DateTime.Parse("10/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/25/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 150.15;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10317;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.69;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10318;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.73;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10319;
            dataRow["OrderDate"] = DateTime.Parse("11/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 64.5;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10320;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 34.57;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10321;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/1/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.43;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10322;
            dataRow["OrderDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/2/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.4;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10323;
            dataRow["OrderDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/5/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.88;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10324;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/6/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 214.27;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10325;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 64.86;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10326;
            dataRow["OrderDate"] = DateTime.Parse("11/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/8/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 77.92;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10327;
            dataRow["OrderDate"] = DateTime.Parse("11/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/9/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 63.36;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10328;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 87.03;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10329;
            dataRow["OrderDate"] = DateTime.Parse("11/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 191.67;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10330;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.75;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10331;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/28/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 10.19;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10332;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 52.84;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10333;
            dataRow["OrderDate"] = DateTime.Parse("11/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/16/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.59;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10334;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.56;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10335;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 42.11;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10336;
            dataRow["OrderDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/21/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 15.51;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10337;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 108.26;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10338;
            dataRow["OrderDate"] = DateTime.Parse("11/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 84.21;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10339;
            dataRow["OrderDate"] = DateTime.Parse("11/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/26/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 15.66;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10340;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 166.31;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10341;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 26.78;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10342;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 54.83;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10343;
            dataRow["OrderDate"] = DateTime.Parse("12/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 110.37;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10344;
            dataRow["OrderDate"] = DateTime.Parse("12/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/30/1994 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 23.29;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10345;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 249.06;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10346;
            dataRow["OrderDate"] = DateTime.Parse("12/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 142.08;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10347;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.1;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10348;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.78;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10349;
            dataRow["OrderDate"] = DateTime.Parse("12/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.63;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10350;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 64.19;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10351;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 162.33;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10352;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.3;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10353;
            dataRow["OrderDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 360.63;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10354;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 53.8;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10355;
            dataRow["OrderDate"] = DateTime.Parse("12/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 41.95;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10356;
            dataRow["OrderDate"] = DateTime.Parse("12/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 36.71;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10357;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 34.88;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10358;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 19.64;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10359;
            dataRow["OrderDate"] = DateTime.Parse("12/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 288.43;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10360;
            dataRow["OrderDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 131.7;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10361;
            dataRow["OrderDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 183.17;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10362;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 96.04;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10363;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 30.54;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10364;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 71.97;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10365;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 22;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10366;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 10.14;
            dataRow["ShipCity"] = "Barcelona";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10367;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 13.55;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10368;
            dataRow["OrderDate"] = DateTime.Parse("12/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 101.95;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10369;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 195.68;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10370;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.17;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10371;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.45;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10372;
            dataRow["OrderDate"] = DateTime.Parse("1/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 890.78;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10373;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 124.12;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10374;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.94;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10375;
            dataRow["OrderDate"] = DateTime.Parse("1/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 20.12;
            dataRow["ShipCity"] = "Elgin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10376;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 20.39;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10377;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 22.21;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10378;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 5.44;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10379;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 45.03;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10380;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 35.03;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10381;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 7.99;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10382;
            dataRow["OrderDate"] = DateTime.Parse("1/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 94.77;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10383;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 34.24;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10384;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 168.64;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10385;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 30.96;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10386;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 13.99;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10387;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 93.63;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10388;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 34.86;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10389;
            dataRow["OrderDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 47.42;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10390;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 126.38;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10391;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 5.45;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10392;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 122.46;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10393;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 126.56;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10394;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 30.34;
            dataRow["ShipCity"] = "Elgin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10395;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 184.41;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10396;
            dataRow["OrderDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 135.35;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10397;
            dataRow["OrderDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 60.26;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10398;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 89.16;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10399;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 27.36;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10400;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 83.93;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10401;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.51;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10402;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 67.88;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10403;
            dataRow["OrderDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 73.79;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10404;
            dataRow["OrderDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 155.97;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10405;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 34.82;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10406;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 108.04;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10407;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 91.48;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10408;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 11.26;
            dataRow["ShipCity"] = "Lille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10409;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 29.83;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10410;
            dataRow["OrderDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 2.4;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10411;
            dataRow["OrderDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 23.65;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10412;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.77;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10413;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 95.66;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10414;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 21.48;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10415;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.2;
            dataRow["ShipCity"] = "Elgin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10416;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 22.72;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10417;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 70.29;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10418;
            dataRow["OrderDate"] = DateTime.Parse("2/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 17.55;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10419;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 137.35;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10420;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 44.12;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10421;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 99.23;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10422;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 3.02;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10423;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 24.5;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10424;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 370.61;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10425;
            dataRow["OrderDate"] = DateTime.Parse("2/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.93;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10426;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 18.69;
            dataRow["ShipCity"] = "Barcelona";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10427;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 31.29;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10428;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 11.09;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10429;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 56.63;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10430;
            dataRow["OrderDate"] = DateTime.Parse("3/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 458.78;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10431;
            dataRow["OrderDate"] = DateTime.Parse("3/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 44.17;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10432;
            dataRow["OrderDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.34;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10433;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 73.83;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10434;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 17.92;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10435;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 9.21;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10436;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 156.66;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10437;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 19.97;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10438;
            dataRow["OrderDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.24;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10439;
            dataRow["OrderDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.07;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10440;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 86.53;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10441;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 73.02;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10442;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 47.94;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10443;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 13.95;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10444;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.5;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10445;
            dataRow["OrderDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 9.3;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10446;
            dataRow["OrderDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 14.68;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10447;
            dataRow["OrderDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 68.66;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10448;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 38.82;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10449;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 53.3;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10450;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.23;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10451;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 189.09;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10452;
            dataRow["OrderDate"] = DateTime.Parse("3/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 140.26;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10453;
            dataRow["OrderDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.36;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10454;
            dataRow["OrderDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 2.74;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10455;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 180.45;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10456;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.12;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10457;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 11.57;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10458;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 147.06;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10459;
            dataRow["OrderDate"] = DateTime.Parse("3/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.09;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10460;
            dataRow["OrderDate"] = DateTime.Parse("3/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.27;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10461;
            dataRow["OrderDate"] = DateTime.Parse("3/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 148.61;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10462;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 6.17;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10463;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 14.78;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10464;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 89;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10465;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 145.04;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10466;
            dataRow["OrderDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 11.93;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10467;
            dataRow["OrderDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.93;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10468;
            dataRow["OrderDate"] = DateTime.Parse("4/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 44.12;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10469;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 60.18;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10470;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 64.56;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10471;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 45.59;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10472;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.2;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10473;
            dataRow["OrderDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 16.37;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10474;
            dataRow["OrderDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 83.49;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10475;
            dataRow["OrderDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 68.52;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10476;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.41;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10477;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.02;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10478;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.81;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10479;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 708.95;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10480;
            dataRow["OrderDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.35;
            dataRow["ShipCity"] = "Lille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10481;
            dataRow["OrderDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 64.33;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10482;
            dataRow["OrderDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 7.48;
            dataRow["ShipCity"] = "Walla Walla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10483;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 15.28;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10484;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 6.88;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10485;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 64.45;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10486;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 30.53;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10487;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 71.07;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10488;
            dataRow["OrderDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.93;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10489;
            dataRow["OrderDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 5.29;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10490;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 210.19;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10491;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 16.96;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10492;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 62.89;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10493;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 10.64;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10494;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 65.99;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10495;
            dataRow["OrderDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.65;
            dataRow["ShipCity"] = "Vancouver";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10496;
            dataRow["OrderDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 46.77;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10497;
            dataRow["OrderDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 36.21;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10498;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 29.75;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10499;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 102.02;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10500;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 42.68;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10501;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 8.85;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10502;
            dataRow["OrderDate"] = DateTime.Parse("5/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 69.32;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10503;
            dataRow["OrderDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 16.74;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10504;
            dataRow["OrderDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 59.13;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10505;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 7.13;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10506;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 21.19;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10507;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 47.45;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10508;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.99;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10509;
            dataRow["OrderDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.15;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10510;
            dataRow["OrderDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 367.63;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10511;
            dataRow["OrderDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 350.64;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10512;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.53;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10513;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 105.65;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10514;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 789.95;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10515;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 204.47;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10516;
            dataRow["OrderDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 62.78;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10517;
            dataRow["OrderDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 32.07;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10518;
            dataRow["OrderDate"] = DateTime.Parse("5/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 218.15;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10519;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 91.76;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10520;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 13.37;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10521;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 17.22;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10522;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 45.33;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10523;
            dataRow["OrderDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 77.63;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10524;
            dataRow["OrderDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 244.79;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10525;
            dataRow["OrderDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 11.06;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10526;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.59;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10527;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 41.9;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10528;
            dataRow["OrderDate"] = DateTime.Parse("6/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.35;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10529;
            dataRow["OrderDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 66.69;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10530;
            dataRow["OrderDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 339.22;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10531;
            dataRow["OrderDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.12;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10532;
            dataRow["OrderDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 74.46;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10533;
            dataRow["OrderDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 188.04;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10534;
            dataRow["OrderDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 27.94;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10535;
            dataRow["OrderDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 15.64;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10536;
            dataRow["OrderDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.88;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10537;
            dataRow["OrderDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 78.85;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10538;
            dataRow["OrderDate"] = DateTime.Parse("6/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.87;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10539;
            dataRow["OrderDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 12.36;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10540;
            dataRow["OrderDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1007.64;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10541;
            dataRow["OrderDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 68.65;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10542;
            dataRow["OrderDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 10.95;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10543;
            dataRow["OrderDate"] = DateTime.Parse("6/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 48.17;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10544;
            dataRow["OrderDate"] = DateTime.Parse("6/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 24.91;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10545;
            dataRow["OrderDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 11.92;
            dataRow["ShipCity"] = "Walla Walla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10546;
            dataRow["OrderDate"] = DateTime.Parse("6/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 194.72;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10547;
            dataRow["OrderDate"] = DateTime.Parse("6/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 178.43;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10548;
            dataRow["OrderDate"] = DateTime.Parse("6/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.43;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10549;
            dataRow["OrderDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 171.24;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10550;
            dataRow["OrderDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.32;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10551;
            dataRow["OrderDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 72.95;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10552;
            dataRow["OrderDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 83.22;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10553;
            dataRow["OrderDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 149.49;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10554;
            dataRow["OrderDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 120.97;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10555;
            dataRow["OrderDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 252.49;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10556;
            dataRow["OrderDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 9.8;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10557;
            dataRow["OrderDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 96.72;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10558;
            dataRow["OrderDate"] = DateTime.Parse("7/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 72.97;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10559;
            dataRow["OrderDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.05;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10560;
            dataRow["OrderDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 36.65;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10561;
            dataRow["OrderDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 242.21;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10562;
            dataRow["OrderDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 22.95;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10563;
            dataRow["OrderDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 60.43;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10564;
            dataRow["OrderDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 13.75;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10565;
            dataRow["OrderDate"] = DateTime.Parse("7/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.15;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10566;
            dataRow["OrderDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 88.4;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10567;
            dataRow["OrderDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 33.97;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10568;
            dataRow["OrderDate"] = DateTime.Parse("7/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 6.54;
            dataRow["ShipCity"] = "Barcelona";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10569;
            dataRow["OrderDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 58.98;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10570;
            dataRow["OrderDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 188.99;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10571;
            dataRow["OrderDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 26.06;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10572;
            dataRow["OrderDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 116.43;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10573;
            dataRow["OrderDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 84.84;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10574;
            dataRow["OrderDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 37.6;
            dataRow["ShipCity"] = "Kirkland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10575;
            dataRow["OrderDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 127.34;
            dataRow["ShipCity"] = "Leipzig";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10576;
            dataRow["OrderDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 18.56;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10577;
            dataRow["OrderDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.41;
            dataRow["ShipCity"] = "Kirkland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10578;
            dataRow["OrderDate"] = DateTime.Parse("7/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 29.6;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10579;
            dataRow["OrderDate"] = DateTime.Parse("7/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.73;
            dataRow["ShipCity"] = "San Francisco";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10580;
            dataRow["OrderDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 75.89;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10581;
            dataRow["OrderDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 3.01;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10582;
            dataRow["OrderDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 27.71;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10583;
            dataRow["OrderDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.28;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10584;
            dataRow["OrderDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 59.14;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10585;
            dataRow["OrderDate"] = DateTime.Parse("8/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 13.41;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10586;
            dataRow["OrderDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.48;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10587;
            dataRow["OrderDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 62.52;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10588;
            dataRow["OrderDate"] = DateTime.Parse("8/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 194.67;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10589;
            dataRow["OrderDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.42;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10590;
            dataRow["OrderDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 44.77;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10591;
            dataRow["OrderDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 55.92;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10592;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 32.1;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10593;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 174.2;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10594;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 5.24;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10595;
            dataRow["OrderDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 96.78;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10596;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.34;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10597;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 35.12;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10598;
            dataRow["OrderDate"] = DateTime.Parse("8/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 44.42;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10599;
            dataRow["OrderDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 29.98;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10600;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 45.13;
            dataRow["ShipCity"] = "Elgin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10601;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 58.3;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10602;
            dataRow["OrderDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.92;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10603;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 48.77;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10604;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 7.46;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10605;
            dataRow["OrderDate"] = DateTime.Parse("8/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 379.13;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10606;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 79.4;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10607;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 200.24;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10608;
            dataRow["OrderDate"] = DateTime.Parse("8/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 27.79;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10609;
            dataRow["OrderDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.85;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10610;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 26.78;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10611;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 80.65;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10612;
            dataRow["OrderDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 544.08;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10613;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.11;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10614;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.93;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10615;
            dataRow["OrderDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.75;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10616;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 116.53;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10617;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 18.53;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10618;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 154.68;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10619;
            dataRow["OrderDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 91.05;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10620;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.94;
            dataRow["ShipCity"] = "Vancouver";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10621;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 23.73;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10622;
            dataRow["OrderDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 50.97;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10623;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 97.18;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10624;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 94.8;
            dataRow["ShipCity"] = "Butte";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10625;
            dataRow["OrderDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 43.9;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10626;
            dataRow["OrderDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 138.69;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10627;
            dataRow["OrderDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 107.46;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10628;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 30.36;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10629;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 85.46;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10630;
            dataRow["OrderDate"] = DateTime.Parse("9/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 32.35;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10631;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.87;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10632;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 41.38;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10633;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 477.9;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10634;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 487.38;
            dataRow["ShipCity"] = "Lille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10635;
            dataRow["OrderDate"] = DateTime.Parse("9/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 47.46;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10636;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.15;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10637;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 201.29;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10638;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 158.44;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10639;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 38.64;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10640;
            dataRow["OrderDate"] = DateTime.Parse("9/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 23.55;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10641;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 179.61;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10642;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 41.89;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10643;
            dataRow["OrderDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 29.46;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10644;
            dataRow["OrderDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.14;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10645;
            dataRow["OrderDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.41;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10646;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 142.33;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10647;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 45.54;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10648;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 14.25;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10649;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 6.2;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10650;
            dataRow["OrderDate"] = DateTime.Parse("9/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 176.81;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10651;
            dataRow["OrderDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 20.6;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10652;
            dataRow["OrderDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.14;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10653;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 93.25;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10654;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 55.26;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10655;
            dataRow["OrderDate"] = DateTime.Parse("10/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.41;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10656;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 57.15;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10657;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 352.69;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10658;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 364.15;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10659;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 105.81;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10660;
            dataRow["OrderDate"] = DateTime.Parse("10/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 111.29;
            dataRow["ShipCity"] = "Elgin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10661;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 17.55;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10662;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.28;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10663;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 113.15;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10664;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.27;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10665;
            dataRow["OrderDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 26.31;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10666;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 232.42;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10667;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 78.09;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10668;
            dataRow["OrderDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 47.22;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10669;
            dataRow["OrderDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 24.39;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10670;
            dataRow["OrderDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 203.48;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10671;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 30.34;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10672;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 95.75;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10673;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 22.76;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10674;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.9;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10675;
            dataRow["OrderDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 31.85;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10676;
            dataRow["OrderDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.01;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10677;
            dataRow["OrderDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.03;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10678;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 388.98;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10679;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 27.94;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10680;
            dataRow["OrderDate"] = DateTime.Parse("10/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 26.61;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10681;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 76.13;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10682;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 36.13;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10683;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.4;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10684;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 145.63;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10685;
            dataRow["OrderDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 33.75;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10686;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 96.5;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10687;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 296.43;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10688;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 299.09;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10689;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.42;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10690;
            dataRow["OrderDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 15.8;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10691;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 810.05;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10692;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/1/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 61.02;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10693;
            dataRow["OrderDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 139.34;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10694;
            dataRow["OrderDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 398.36;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10695;
            dataRow["OrderDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.72;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10696;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 102.55;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10697;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/6/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 45.52;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10698;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 272.47;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10699;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.58;
            dataRow["ShipCity"] = "Leipzig";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10700;
            dataRow["OrderDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 65.1;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10701;
            dataRow["OrderDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 220.31;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10702;
            dataRow["OrderDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 23.94;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10703;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 152.3;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10704;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.78;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10705;
            dataRow["OrderDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.52;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10706;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 135.63;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10707;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 21.74;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10708;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.96;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10709;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 210.8;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10710;
            dataRow["OrderDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.98;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10711;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 52.41;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10712;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 89.93;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10713;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 167.05;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10714;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 24.49;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10715;
            dataRow["OrderDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 63.2;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10716;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 22.57;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10717;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 59.25;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10718;
            dataRow["OrderDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 170.88;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10719;
            dataRow["OrderDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 51.44;
            dataRow["ShipCity"] = "San Francisco";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10720;
            dataRow["OrderDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 9.53;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10721;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 48.92;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10722;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 74.58;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10723;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 21.72;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10724;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 57.75;
            dataRow["ShipCity"] = "Montréal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10725;
            dataRow["OrderDate"] = DateTime.Parse("12/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 10.83;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10726;
            dataRow["OrderDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.56;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10727;
            dataRow["OrderDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 89.9;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10728;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.33;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10729;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 141.06;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10730;
            dataRow["OrderDate"] = DateTime.Parse("12/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 20.12;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10731;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 96.65;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10732;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.97;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10733;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 110.11;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10734;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.63;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10735;
            dataRow["OrderDate"] = DateTime.Parse("12/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 45.97;
            dataRow["ShipCity"] = "San Francisco";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10736;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 44.1;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10737;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.79;
            dataRow["ShipCity"] = "Reims";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10738;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.91;
            dataRow["ShipCity"] = "Paris";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10739;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 11.08;
            dataRow["ShipCity"] = "Reims";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10740;
            dataRow["OrderDate"] = DateTime.Parse("12/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 81.88;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10741;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 10.96;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10742;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 243.73;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10743;
            dataRow["OrderDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 23.72;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10744;
            dataRow["OrderDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 69.19;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10745;
            dataRow["OrderDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 3.52;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10746;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 31.43;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10747;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 117.33;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10748;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 232.55;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10749;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 61.53;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10750;
            dataRow["OrderDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 79.3;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10751;
            dataRow["OrderDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 130.79;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10752;
            dataRow["OrderDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.39;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10753;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 7.7;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10754;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 2.38;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10755;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 16.71;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10756;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 73.21;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10757;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.19;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10758;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 138.17;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10759;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 11.99;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10760;
            dataRow["OrderDate"] = DateTime.Parse("1/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 155.64;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10761;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 18.66;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10762;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 328.74;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10763;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 37.35;
            dataRow["ShipCity"] = "Lille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10764;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 145.45;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10765;
            dataRow["OrderDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 42.74;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10766;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 157.55;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10767;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.59;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10768;
            dataRow["OrderDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 146.32;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10769;
            dataRow["OrderDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 65.06;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10770;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 5.32;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10771;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 11.19;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10772;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 91.28;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10773;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 96.43;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10774;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 48.2;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10775;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 20.25;
            dataRow["ShipCity"] = "Butte";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10776;
            dataRow["OrderDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 351.53;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10777;
            dataRow["OrderDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.01;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10778;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 6.79;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10779;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.13;
            dataRow["ShipCity"] = "Leipzig";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10780;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 42.13;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10781;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 73.16;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10782;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.1;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10783;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 124.98;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10784;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 70.09;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10785;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.51;
            dataRow["ShipCity"] = "Caracas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10786;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 110.87;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10787;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 249.93;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10788;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 42.7;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10789;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 100.6;
            dataRow["ShipCity"] = "Lille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10790;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 28.23;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10791;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 16.85;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10792;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 23.79;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10793;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.52;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10794;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 21.49;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10795;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 126.66;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10796;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 26.52;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10797;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 33.35;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10798;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.33;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10799;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 30.76;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10800;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 137.44;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10801;
            dataRow["OrderDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 97.09;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10802;
            dataRow["OrderDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 257.26;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10803;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 55.23;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10804;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 27.33;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10805;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 237.34;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10806;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 22.11;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10807;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.36;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10808;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 45.53;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10809;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.87;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10810;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.33;
            dataRow["ShipCity"] = "Vancouver";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10811;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 31.22;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10812;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 59.78;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10813;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 47.38;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10814;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 130.94;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10815;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 14.62;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10816;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 719.78;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10817;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 306.07;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10818;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 65.48;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10819;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 19.76;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10820;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 37.52;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10821;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 36.68;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10822;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 7;
            dataRow["ShipCity"] = "Kirkland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10823;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 163.97;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10824;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.23;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10825;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 79.25;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10826;
            dataRow["OrderDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 7.09;
            dataRow["ShipCity"] = "Strasbourg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10827;
            dataRow["OrderDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 63.54;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10828;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 90.85;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10829;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 154.72;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10830;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 81.83;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10831;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 72.19;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10832;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 43.26;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10833;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 71.49;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10834;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 29.78;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10835;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 69.53;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10836;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 411.88;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10837;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 13.32;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10838;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 59.28;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10839;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 35.43;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10840;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.71;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10841;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 424.3;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10842;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 54.42;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10843;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 9.26;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10844;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.22;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10845;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 212.98;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10846;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 56.46;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10847;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 487.57;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10848;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 38.24;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10849;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.56;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10850;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 49.19;
            dataRow["ShipCity"] = "Lyon";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10851;
            dataRow["OrderDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 160.55;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10852;
            dataRow["OrderDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 174.05;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10853;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 53.83;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10854;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 100.22;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10855;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 170.97;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10856;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 58.43;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10857;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 188.85;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10858;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 52.51;
            dataRow["ShipCity"] = "Versailles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10859;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 76.1;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10860;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 19.26;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10861;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 14.93;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10862;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 53.23;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10863;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 30.26;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10864;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.04;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10865;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 348.14;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10866;
            dataRow["OrderDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 109.11;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10867;
            dataRow["OrderDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.93;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10868;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 191.27;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10869;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 143.28;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10870;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 12.04;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10871;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 112.27;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10872;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 175.32;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10873;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.82;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10874;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 19.58;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10875;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 32.37;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10876;
            dataRow["OrderDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 60.42;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10877;
            dataRow["OrderDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 38.06;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10878;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 46.69;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10879;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 8.5;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10880;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 88.01;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10881;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.84;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10882;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 23.1;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10883;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 0.53;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10884;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 90.97;
            dataRow["ShipCity"] = "San Francisco";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10885;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 5.64;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10886;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 4.99;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10887;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.25;
            dataRow["ShipCity"] = "Barcelona";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10888;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 51.87;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10889;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 280.61;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10890;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 32.76;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10891;
            dataRow["OrderDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 20.37;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10892;
            dataRow["OrderDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 120.27;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10893;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 77.78;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10894;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 116.13;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10895;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 162.75;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10896;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 32.45;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10897;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 603.54;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10898;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.27;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10899;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 1.21;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10900;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.66;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10901;
            dataRow["OrderDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 62.09;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10902;
            dataRow["OrderDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 44.15;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10903;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 36.71;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10904;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 162.95;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10905;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.72;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10906;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 26.29;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10907;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 9.19;
            dataRow["ShipCity"] = "Paris";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10908;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 32.96;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10909;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 53.05;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10910;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 38.11;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10911;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 38.19;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10912;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 580.91;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10913;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 33.05;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10914;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 21.19;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10915;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.51;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10916;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 63.77;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10917;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.29;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10918;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 48.83;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10919;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 19.8;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10920;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 29.61;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10921;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 176.48;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10922;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 62.74;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10923;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 68.26;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10924;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 151.52;
            dataRow["ShipCity"] = "Luleå";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10925;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.27;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10926;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 39.92;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10927;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 19.79;
            dataRow["ShipCity"] = "Versailles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10928;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.36;
            dataRow["ShipCity"] = "Barcelona";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10929;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 33.93;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10930;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 15.55;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10931;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 13.6;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10932;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 134.64;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10933;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 54.15;
            dataRow["ShipCity"] = "Cowes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10934;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 32.01;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10935;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 47.59;
            dataRow["ShipCity"] = "Resende";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10936;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 33.68;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10937;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 31.51;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10938;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 31.89;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10939;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 76.33;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10940;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 19.77;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10941;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 400.81;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10942;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 17.95;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10943;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.17;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10944;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 52.92;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10945;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 10.22;
            dataRow["ShipCity"] = "Leipzig";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10946;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 27.2;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10947;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.26;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10948;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 23.39;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10949;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 74.44;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10950;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 2.5;
            dataRow["ShipCity"] = "Bergamo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10951;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 30.85;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10952;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 40.42;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10953;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 23.72;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10954;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 27.91;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10955;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 3.26;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10956;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 44.65;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10957;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 105.36;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10958;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 49.56;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10959;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.98;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10960;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 2.08;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10961;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 104.47;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10962;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 275.79;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10963;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 2.7;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10964;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 87.38;
            dataRow["ShipCity"] = "Paris";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10965;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 144.38;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10966;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 27.19;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10967;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 62.22;
            dataRow["ShipCity"] = "Münster";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10968;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 74.6;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10969;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.21;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10970;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 16.16;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10971;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 121.82;
            dataRow["ShipCity"] = "Nantes";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10972;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.02;
            dataRow["ShipCity"] = "Versailles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10973;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 15.17;
            dataRow["ShipCity"] = "Versailles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10974;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 12.96;
            dataRow["ShipCity"] = "Lander";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10975;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 32.27;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10976;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 37.97;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10977;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 208.5;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10978;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 32.82;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10979;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 353.07;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10980;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.26;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10981;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 193.37;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10982;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 14.01;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10983;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 657.54;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10984;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 211.22;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10985;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 91.51;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10986;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 217.86;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10987;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 185.48;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10988;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 61.14;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10989;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 34.76;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10990;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 117.61;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10991;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 38.51;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10992;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.27;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10993;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 8.81;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10994;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 65.53;
            dataRow["ShipCity"] = "Århus";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10995;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 46;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10996;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 1.12;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10997;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 73.91;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10998;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 20.31;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10999;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 96.35;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11000;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 55.12;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11001;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 197.3;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11002;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 141.16;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11003;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 14.91;
            dataRow["ShipCity"] = "Butte";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11004;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 44.84;
            dataRow["ShipCity"] = "Bruxelles";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11005;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.75;
            dataRow["ShipCity"] = "Helsinki";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11006;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 25.19;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11007;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 202.24;
            dataRow["ShipCity"] = "Lisboa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11008;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 79.46;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11009;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 59.11;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11010;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 28.71;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11011;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 1.21;
            dataRow["ShipCity"] = "Berlin";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11012;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 242.95;
            dataRow["ShipCity"] = "München";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11013;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 32.99;
            dataRow["ShipCity"] = "Madrid";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11014;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 23.6;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11015;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 4.62;
            dataRow["ShipCity"] = "Stavern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11016;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 33.8;
            dataRow["ShipCity"] = "Colchester";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11017;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 754.26;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11018;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 11.65;
            dataRow["ShipCity"] = "Portland";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11019;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 3.17;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11020;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 43.3;
            dataRow["ShipCity"] = "Köln";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11021;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 297.18;
            dataRow["ShipCity"] = "Cunewalde";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11022;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 6.27;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11023;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 123.83;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11024;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 74.36;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11025;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 29.17;
            dataRow["ShipCity"] = "Oulu";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11026;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 47.09;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11027;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 52.52;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11028;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 29.59;
            dataRow["ShipCity"] = "Brandenburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11029;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 47.84;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11030;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 830.75;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11031;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 227.22;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11032;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 606.19;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11033;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 84.74;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11034;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 40.32;
            dataRow["ShipCity"] = "Anchorage";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11035;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 0.17;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11036;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 149.47;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11037;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 3.2;
            dataRow["ShipCity"] = "Sevilla";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11038;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 29.59;
            dataRow["ShipCity"] = "Charleroi";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11039;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 65;
            dataRow["ShipCity"] = "I. de Margarita";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11040;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 18.84;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11041;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 48.22;
            dataRow["ShipCity"] = "Bern";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11042;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 29.99;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11043;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.8;
            dataRow["ShipCity"] = "Paris";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11044;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.72;
            dataRow["ShipCity"] = "Warszawa";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11045;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 70.58;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11046;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 71.64;
            dataRow["ShipCity"] = "Stuttgart";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11047;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 46.62;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11048;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 24.12;
            dataRow["ShipCity"] = "Tsawassen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11049;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 8.34;
            dataRow["ShipCity"] = "Campinas";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11050;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 59.41;
            dataRow["ShipCity"] = "Bräcke";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11051;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 2.79;
            dataRow["ShipCity"] = "Toulouse";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11052;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 67.26;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11053;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 53.05;
            dataRow["ShipCity"] = "Salzburg";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11054;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.33;
            dataRow["ShipCity"] = "Buenos Aires";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11055;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/25/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 120.92;
            dataRow["ShipCity"] = "San Cristóbal";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11056;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 278.96;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11057;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 4.13;
            dataRow["ShipCity"] = "London";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11058;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 31.14;
            dataRow["ShipCity"] = "Mannheim";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11059;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 85.8;
            dataRow["ShipCity"] = "Rio de Janeiro";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11060;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 10.98;
            dataRow["ShipCity"] = "Torino";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11061;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1996 12:00:00 AM");
            dataRow["ShipVia"] = 3;
            dataRow["Freight"] = 14.01;
            dataRow["ShipCity"] = "Eugene";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11062;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 29.93;
            dataRow["ShipCity"] = "Reggio Emilia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11063;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 81.73;
            dataRow["ShipCity"] = "Cork";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11064;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 30.09;
            dataRow["ShipCity"] = "Boise";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11065;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 12.91;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11066;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 44.72;
            dataRow["ShipCity"] = "Seattle";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11067;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 7.98;
            dataRow["ShipCity"] = "Aachen";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11068;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 81.75;
            dataRow["ShipCity"] = "São Paulo";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11069;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 15.67;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11070;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 136;
            dataRow["ShipCity"] = "Frankfurt a.M. ";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11071;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 1;
            dataRow["Freight"] = 0.93;
            dataRow["ShipCity"] = "Barquisimeto";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11072;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 258.64;
            dataRow["ShipCity"] = "Graz";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11073;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 24.95;
            dataRow["ShipCity"] = "México D.F.";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11074;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 18.44;
            dataRow["ShipCity"] = "København";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11075;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 6.19;
            dataRow["ShipCity"] = "Genève";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11076;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 38.28;
            dataRow["ShipCity"] = "Marseille";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11077;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["ShipVia"] = 2;
            dataRow["Freight"] = 8.53;
            dataRow["ShipCity"] = "Albuquerque";
            table.Rows.Add(dataRow);

            return table;
        }
    }
}
