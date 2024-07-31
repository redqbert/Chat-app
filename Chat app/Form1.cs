using System.Net.Sockets;
using System.Net;
using System.Text;
using System;


namespace Chat_app
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint Local, Visitante;

        public Form1()
        {
            InitializeComponent();

            //Crear sockets
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            localip.Text = GetLocalIP();

            Ipvisit.Text = GetLocalIP();

        }


        private string GetLocalIP()
        {
            IPHostEntry entry = new IPHostEntry();
            entry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress direccion in entry.AddressList)
            {
                if (direccion.AddressFamily == AddressFamily.InterNetwork)
                {
                    return direccion.ToString();
                }

            }
            return "127.0.0.1";

        }

        private void Mensaje(IAsyncResult resultado)
        {
            try
            {
                int tamanio = socket.EndReceiveFrom(resultado, ref Visitante);
                if (tamanio > 0)
                {
                    byte[] informacion = new byte[1024];
                    informacion = (byte[])resultado.AsyncState;

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string mensaje = encoding.GetString(informacion);

                    Historial.Items.Add(mensaje);
                }

                byte[] buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref Visitante, new AsyncCallback(Mensaje), buffer);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Local = new IPEndPoint(IPAddress.Parse(GetLocalIP()), Convert.ToInt32(PuertoLocal.Text));
                socket.Bind(Local);

                Visitante = new IPEndPoint(IPAddress.Parse(GetLocalIP()), Convert.ToInt32(PuertoVisitante.Text));
                socket.Connect(Visitante);

                byte[] buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref Visitante, new AsyncCallback(Mensaje), buffer);
                button2.Enabled = true;

                Chat.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void localip_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
