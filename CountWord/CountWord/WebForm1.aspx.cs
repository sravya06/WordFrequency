using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CountWord
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs("C:\\Users\\ssriramoju\\Desktop" + filename);
                    using (StreamReader sr = new StreamReader("C:\\Users\\ssriramoju\\Desktop" + filename))
                    {
                        string line = sr.ReadToEnd();
                        Label1.Text = line;
                        string key = TextBox1.Text.ToString();
                        int wordcount = key.Split(' ').Count();
                        var parts = line.Split(' ');
                        List<string> searchstring = new List<string>();
                        for( int i=0;i<parts.Count(); i++)
                        {
                            if(i<=parts.Count() - wordcount)
                            {
                                string sequence = "";
                                for (int j=0;j< wordcount; j++)
                                {
                                    sequence += parts[i + j] + " ";
                                }
                                if (sequence.Length > 0)
                                    sequence = sequence.Remove(sequence.Count() - 1, 1);
                                searchstring.Add(sequence);

                            }

                            int count = searchstring.Count(p => p == key);
                            Label2.Text = "Total no of search Words : " + count.ToString();

                        }


                    }

                }
                catch(Exception ex )
                {
                    Label2.Text = ex.Message;
                }

            }
        }
    }
}