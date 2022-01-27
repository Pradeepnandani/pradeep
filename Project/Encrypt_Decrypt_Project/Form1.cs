using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace encrypydecrypt
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        

        private void BTNENCRYPT_Click(object sender, EventArgs e)
        {
           
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            
            var str = TXTVALUE.Text;
            string encryptedstring = encrypt_decrypt.encryptstring(key, str);
              TXTENCRYPT.Text = encryptedstring;
        }
          public string Encryptedstring 
          {
              get{ return encryptedstring ;}

              set { value = encryptedstring; }
             }
          

       

        private void BTNDECRYPT_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            var str = TXTVALUE.Text;
            var decryptedstring = encrypt_decrypt.decryptor(key, TXTENCRYPT.Text);
            TXTDECRYPT.Text = decryptedstring;
        }

       
    
public  string encryptedstring { get; set; }}
}
