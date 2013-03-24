using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    //当页面加载时发生
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //“Button1”单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = "你输入了：";
        //将“Label1”的“Text”属性设置为给定的字符串
        this.Label1.Text = s+this.TextBox1.Text;
    }
}
