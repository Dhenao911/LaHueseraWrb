using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conector = DB.conectar("laHuesera");
                string consultar = "Select *from Peliculas where CodigoVideo = '" + txCodigo.Text + "'";
                SqlDataReader tabla = DB.consulta(consultar, conector);

                if (tabla.Read())
                {
                    txCodigo.Text = tabla["CodigoVideo"].ToString();
                    txTitulo.Text = tabla["Título"].ToString();
                    txDescripcion.Text = tabla["Descripción"].ToString();
                    txGenero.Text = tabla["Género"].ToString();
                    txAño.Text = tabla["AñoLanzamiento"].ToString();
                    txDuraccion.Text = tabla["DuraciónMinutos"].ToString();
                    txEstado.Text = tabla["Estado"].ToString();

                    if (tabla["Imagen"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])tabla["Imagen"];

                        // Asegúrate de que imageData contiene datos válidos
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbImagen.Image = System.Drawing.Image.FromStream(ms); // Asigna la imagen al PictureBox
                            }
                        }
                        else
                        {
                            pbImagen.Image = null; // O asigna una imagen predeterminada
                        }
                    }
                }
                DB.cerrar(conector);

            }
            catch (SqlException ex)
            {
                txDescripcion.Text = "Error sql: " + ex.Message;
            }

        }
    }
}
