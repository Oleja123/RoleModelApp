using Services.Utils;
using System;
using System.Windows.Forms;

public class LoginForm : Form
{
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;

    private InMemoryDb _db;
    private UserService _userService;

    public LoginForm()
    {
        var (key, iv) = KeyStorage.LoadKeyIv("key_iv.dat");

        _db = new InMemoryDb("auth_encrypted.db", key, iv);
        _userService = new UserService(_db);
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "Вход";
        this.Width = 1000;
        this.Height = 1000;

        Label lblUser = new Label() { Text = "Имя пользователя:", Left = 10, Top = 20, Width = 120 };
        txtUsername = new TextBox() { Left = 140, Top = 20, Width = 120 };

        Label lblPass = new Label() { Text = "Пароль:", Left = 10, Top = 60, Width = 120 };
        txtPassword = new TextBox() { Left = 140, Top = 60, Width = 120, UseSystemPasswordChar = true };

        btnLogin = new Button() { Text = "Войти", Left = 140, Top = 100, Width = 80 };
        btnLogin.Click += BtnLogin_Click;

        this.Controls.Add(lblUser);
        this.Controls.Add(txtUsername);
        this.Controls.Add(lblPass);
        this.Controls.Add(txtPassword);
        this.Controls.Add(btnLogin);
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        try
        {

            bool ok = _userService.VerifyPassword(username, password);

            if (ok)
                MessageBox.Show($"Добро пожаловать, {username}!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
        }
    }

    private void InitializeComponent()
    {

    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _db?.Dispose();
    }
}
