using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBuilder
{
    public partial class Form1 : Form
    {

        private string[] comp = new string[] { "CompilerVersion", ".exe", ".pdb", "v4.0", "--------Build succeeded-------" };
        private string[] myref = new string[] { "mscorlib.dll ", "System.Core.dll" };

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompile_Click(object sender, EventArgs e)
        {

            /*
             namespace CodeBuilder
{
   static class Program
  {     
    static void Main()
        {
	System.Console.WriteLine("test");
	 System.  Console.ReadKey();

       }
   }
}
             */
            //خالی کردن تکست استاتوس برای کد
            txtstatus.Clear();

            //ساخت یک آبحکت از کلاس شخصی کننده کد سی شارپ وتعیین وزژن فرم ورک
            CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { comp[0], comp[3]} });

            ///ساخت آبجکتی از کلاس کامپل کننده موارد و دادن ریفرنس ها به او در یک آرایه جدید و بعد مکان و اسم فایل ساخته شده رو
            ///تعیین میکنیم و بعد روشن قرارش میدیم
            CompilerParameters parameters = new CompilerParameters(new[] { myref[0], myref[1] }, txtSavePath.Text + ".exe", true);

            //دستور ساخت فایل اجرایی 
            parameters.GenerateExecutable = true;

            //نتیجه کامپایل رو ازش میخوایم که اگه خطایی داشته باشه بهمون بگه کجاست و ورودی هایی که میدیم دوتاست
            //همین نام پارامتر بالا و مکان نمابش استاتوس
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, txtSource.Text);

            //یک شرط تعیین میکنیم که اگه  خطا داشت خطا ها رو نشونمون بده و در در غیر اینصورت اگه کامپایل بدون خطا بود فایل رو اجرا کن 
            if (results.Errors.HasErrors)
            {
                //نمایش همه خطا ها به صورت یک آرایه در استاتوس تکست
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => txtstatus.Text += error.ErrorText + "\r\n");
            }
            else
            {
                //پیغام موفقعیت
                txtstatus.Text =comp[4] ;
                ///فایل رو که در مکان سیو شده کامپل و ذخیره کردی رو اجرا کن
                Process.Start(txtSavePath.Text + comp[1]);
            }

            //فایل ساخته شده غیر لازم رو پاک کنن
            File.Delete(txtSavePath.Text + comp[2]);
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = s.FileName;
            }
        }
    }
}
