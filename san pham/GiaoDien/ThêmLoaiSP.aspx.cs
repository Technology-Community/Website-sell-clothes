﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class GiaoDien_ThêmLoaiSP : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductGroup prg = new ProductGroup();
        prg.ProductGroupName= txtTenLoaiSP.Text;
        db.ProductGroups.InsertOnSubmit(prg);
        db.SubmitChanges();
        txtTenLoaiSP.Text = "";
        
    }
    protected void btnThemLoaiSP_Click(object sender, EventArgs e)
    {
        
    }
}
