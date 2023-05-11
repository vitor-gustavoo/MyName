using System;


namespace Nome;

public class Nome : Form
{
    private Label lblTitulo;
    private TextBox txtNome;
    private Button btnOla;
    private Button btnSair;

  

    public Nome()

    {
        // Tamanho da tela
        Size = new Size(400,300);

        // Define nome navbar
        this.Text = "Nome";

        //Define parametros da Label Menu

        lblTitulo = new Label();
        lblTitulo.Text = "Nome";
        lblTitulo.Location = new Point(160,20);
        lblTitulo.Size = new Size(80,20);
        lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(lblTitulo);

        txtNome = new TextBox();
        txtNome.Location = new Point (50,50);
        txtNome.Size = new Size(250,40);
        txtNome.Font = new Font("Arial", 10, FontStyle.Regular);
        this.Controls.Add(txtNome);

        // Define parametros do botão Produto
        
        btnOla = new Button();
        btnOla.Text = "Olá";
        btnOla.Location = new Point(130, 80);
        btnOla.Size = new Size(120, 30);
        btnOla.Click += (sender, e) => {
        MessageBox.Show("Olá" + ' ' + this.txtNome.Text);
        };

        this.Controls.Add(btnOla);

        // Define parametros do botão Sair

        btnSair = new Button();
        btnSair.Text = "Fechar";
        btnSair.Location = new Point(130, 140);
        btnSair.Size =new Size(120, 30);
        btnSair.Click += (sender, e) => {
        Application.Exit();
        };
        this.Controls.Add(btnSair);
        
    }
        
}
