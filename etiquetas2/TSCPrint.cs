using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace etiquetas2
{
	public partial class TSCPrint : Form
		{
			[DllImport("TSCLIB.dll", EntryPoint = "about")]
			public static extern bool about();

			[DllImport("TSCLIB.dll", EntryPoint = "openport")]
			public static extern bool openport(string printer);

			[DllImport("TSCLIB.dll", EntryPoint = "barcode")]
			public static extern int barcode(string x, string y, string type,
			string height, string readable, string rotation,
			string narrow, string wide, string code);

			[DllImport("TSCLIB.dll", EntryPoint = "clearbuffer")]
			public static extern int clearbuffer();

			[DllImport("TSCLIB.dll", EntryPoint = "closeport")]
			public static extern int closeport();

			[DllImport("TSCLIB.dll", EntryPoint = "downloadpcx")]
			public static extern int downloadpcx(string filename, string image_name);

			[DllImport("TSCLIB.dll", EntryPoint = "formfeed")]
			public static extern int formfeed();

			[DllImport("TSCLIB.dll", EntryPoint = "nobackfeed")]
			public static extern int nobackfeed();

			[DllImport("TSCLIB.dll", EntryPoint = "printerfont")]
			public static extern int printerfont(string x, string y, string fonttype,
			string rotation, string xmul, string ymul,
			string text);

			[DllImport("TSCLIB.dll", EntryPoint = "printlabel")]
			public static extern int printlabel(string set, string copy);

			[DllImport("TSCLIB.dll", EntryPoint = "sendcommand")]
			public static extern int sendcommand(string printercommand);

			[DllImport("TSCLIB.dll", EntryPoint = "setup")]
			public static extern int setup(string width, string height,
			string speed, string density,
			string sensor, string vertical,
			String offset);

			[DllImport("TSCLIB.dll", EntryPoint = "windowsfont")]
			public static extern int windowsfont(int x, int y, int fontheight,
			int rotation, int fontstyle, int fontunderline,
			string szFaceName, string content);
			public TSCPrint()
			{
				InitializeComponent();
				//about();
			}

			

			private void button1_Click(object sender, EventArgs e)
			{
			string nomePaciente, nomeMae, numeroProntuario, dataNascimento;
			nomePaciente = txtNomePaciente.Text;
			nomeMae = txtNomeMae.Text;
			numeroProntuario = txtNumeroProntuario.Text;
			dataNascimento = txtDataNascimento.Text;

			openport("TSC"); //A porta deve ser aberta no nome da impressora
							 //	sendcommand("BLINE 4 mm, 115 mm");
			//setup("25", "220", "10", "8", "1", "6", "10"); // Setup the media size and sensor type info
														   /*SETUP DICIONARY: 
															* setup(a, b, c, d, e, f, g)
															* a: define a largura, em milímetros
															* b: define a altura, em milímetros
															* c: define a velocidade de impressão - min:1 max:12
															* d: define a densidade do traço - min:0 max:15
															* e: define o tipo do sensor usado - 0:GAP vertical, 1:sensor de marca negra
															* f: define o tamanho do gap ou sensor negro, em milímetros
															* g: define a distância do gap ou sensor negro.*/

			clearbuffer(); // Clear image buffer
						   //barcode("100", "100", "128", "100", "1", "0", "2", "2", "Barcode Test"); // Drawing barcode

			/*PRINTERFONT DICIONARY:
				 * printerfont(a, b, c, d, e, f, g)
				 * a: define o ponto de início do texto no eixo X, em pontos. 1 ponto = 0.1mm
				 * b: define o ponto de início do texto no eixo y, em pontos. ""
				 * c: define tamanho da fonte: de 1 a 5
				 * d: define o grau de rotação do texto
				 * e: define a taxa de magnificação do texto ao longo do eixo x
				 * f: idem, eixo y
				 * g: define o conteúdo do texto a ser impresso
				 */
			//sendcommand("QRCODE 30,30,M,6,0,M2,\"BRADY123\"");
			//sendcommand("BACKUP 80");
			printerfont("160", "0", "2", "90", "1", "1", "NOVO"); // Drawing printer font
			printerfont("120", "0", "2", "90", "1", "1", "TESTE");
			printerfont("80", "0", "2", "90", "1", "1", "IMPRESS");
			printerfont("40", "0", "2", "90", "1", "1", "TDP");

			/*
			printerfont("160", "0", "2", "90", "1", "1", "Nome do Paciente: " + nomePaciente); // Drawing printer font
			printerfont("120", "0", "2", "90", "1", "1", "Prontuario: " + numeroProntuario); // Drawing printer font
			printerfont("80",  "0", "2", "90", "1", "1", "Nome da Mae: " + nomeMae); // Drawing printer font
			printerfont("40",  "0", "2", "90", "1", "1", "Data de Nasc.:" + dataNascimento); // Drawing printer font
			*/



			//windowsfont(100, 300, 24, 0, 0, 0, "ARIAL", "ti"); // Draw windows font
			/*WINDOWFONT DICIONARY:
			 * windowfont (a, b, c, d, e, f, g)
			 * a: define o ponto de início do texto no eixo X, em pontos. 1 ponto = 0.1mm
			 * b: define o ponto de início do texto no eixo y, em pontos. ""
			 * c: define tamanho da fonte: de 1 a 5
			 * d: define o grau de rotação do texto
			 * e: define o estilo da fonte (0 - normal, 1 - italico, 2 - negrito, 3 - negrito e itálico)
			 * f: define se a fonte é sublinhada (0 - não sublinhada, 1 - sublinhada)
			 * g: define o nome da fonte (Arial, timew new roman, etc, de acordo com o sistema operacional)
			 * h: define o conteúdo do texto a ser impresso
			 */
			//downloadpcx ("UL.PCX", "UL.PCX"); // Download PCX file into printer
			//sendcommand ("PUTPCX 100,400, /" UL.PCX / ""); // Drawing PCX graphic
			nobackfeed();
			printlabel("1", "1"); // Print labels
								  /*PRI-NTLABLE DICIONARY:
								  * printlabel (a, b)
								  * a: define o número de labels
								  * b: define a quantidade de cópias
								  */
			//sendcommand("SET PEEL ON");
			closeport(); // Close specified printer driver
		

			}

		private void button2_Click(object sender, EventArgs e)
		{
			openport("TSC");
			sendcommand("SET GAP AUTO");
			closeport();
		}
	}
}
