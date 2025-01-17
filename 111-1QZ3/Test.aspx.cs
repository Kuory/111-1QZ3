﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class Test : System.Web.UI.Page
    {
          
        string[] s_City = new string[3] { "台北市", "新北市", "台中市" };
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!IsPostBack)
                {
                    for (int I = 0; I < s_City.Length; I++)
                    {
                        ListItem a_C = new ListItem();
                        a_C.Text = a_C.Value = s_City[I];
                        dpl_City.Items.Add(a_C);
                    }
                }
                
                
                  mt_GenSecondList();
            }
        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                mt_GenSecondList();
            }
        }
        protected void mt_GenSecondList()
        {
            int i_ind = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int J = 0; J < s_Area.GetLength(1); J++)
            {
                ListItem a_C = new ListItem();
                a_C.Text = a_C.Value = s_Area[i_ind, J];

                dpl_Area.Items.Add(a_C);
            }
        }
    }
}