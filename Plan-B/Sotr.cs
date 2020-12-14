using System;
using System.Data;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using MaterialSkin;

namespace Plan_B
{
    public partial class Sotr : MaterialSkin.Controls.MaterialForm
    {

        private readonly string TemlpateFileName = @"M:\Template.docx";
        string ResourseName;
        string TaskName;
        string AppointmentDate;
        string CompletionDate;
        string NameSotr = "Никита";
        string FamSotr = "Задорожнюк";
        string OtchSotr = "Евгеньевич";
        string DolzhnSotr = "Веб-дизайнер";
        int UserId;
        string CurDate = DateTime.Now.ToLongDateString();//Заносим в переменную текущую дату и время

        public Sotr()
        {
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
            LoadData();
        }

        //Выгрузка в таблицу данных о сотрудниках из БД
        private void LoadData()
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_postavl_zadachi, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach, Status_vipoln from Postavl_zadachi INNER JOIN Zadacha on Id_zadacha = Zadacha_ID INNER JOIN Resourse on Id_resourse = Resourse_ID where Sotr_ID =  "+Program.UserId+"");
            DGV2.DataSource = dtbl;
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResourseName = DGV2.CurrentRow.Cells[3].Value.ToString();
            TaskName = DGV2.CurrentRow.Cells[1].Value.ToString();
            AppointmentDate = DGV2.CurrentRow.Cells[4].Value.ToString();
            CompletionDate = DGV2.CurrentRow.Cells[5].Value.ToString();
        }


        private void BtnMakeOtchet_Click(object sender, EventArgs e)
        {
            
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {

                saveFileDialog1.InitialDirectory = "C:\tmp";
                // Задание возможных расширений для файла.
                saveFileDialog1.Filter = "docx files (*.docx)|*.docx|All files|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Код по сохранению...
                    string fileName = saveFileDialog1.FileName;
                    // ...
                }

                var wordDocument = wordApp.Documents.Open(TemlpateFileName);
                ReplaceWordStub("{TaskName}", TaskName, wordDocument);
                ReplaceWordStub("{ResourseName}", ResourseName, wordDocument);
                ReplaceWordStub("{AppointmentDate}", AppointmentDate, wordDocument);
                ReplaceWordStub("{CompletionDate}", CurDate, wordDocument);
                ReplaceWordStub("{I}", NameSotr, wordDocument);
                ReplaceWordStub("{F}", FamSotr, wordDocument);
                ReplaceWordStub("{O}", OtchSotr, wordDocument);
                ReplaceWordStub("{Dolzhn}", DolzhnSotr, wordDocument);

                wordDocument.SaveAs(@"C:\Отчеты\Отчет Задорожнюк.docx");
                wordDocument.Close();
                MaterialMessageBox.Show("Отчет успешно сформирован","Оповещение", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MaterialMessageBox.Show("Произошла ошибка", "Что-то пошло не так", MessageBoxButtons.OK);
            }
            
            finally
            {
                wordApp.Quit();
            }


        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //Получаем содержимое всего документа
            range.Find.ClearFormatting();//Очишаем от предидущих форматирований
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dbConnector.ExecCommand("UPDATE Postavl_zadachi SET Status_vipoln = 'Задача завершена' where Sotr_ID = "+Program.UserId+"");
            //dbConnector.ExecCommand("UPDATE Postavl_zadachi SET Data_vipoln = "+CurDate+" where Sotr_ID = " + Program.UserId + "");
            dbConnector.ExecCommand("UPDATE Postavl_zadachi SET Data_vipoln = '25 инюя 2019 г.' where Sotr_ID = " + Program.UserId + "");
            dbConnector.ExecCommand("UPDATE Sotr SET Sost_sotr = 'Свободен' where Id_sotr = " + Program.UserId + "");
            dtbl = dbConnector.GetTable("SELECT Id_postavl_zadachi, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach, Status_vipoln from Postavl_zadachi INNER JOIN Zadacha on Id_zadacha = Zadacha_ID INNER JOIN Resourse on Id_resourse = Resourse_ID where Sotr_ID =  " + Program.UserId + "");
            DGV2.DataSource = dtbl;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Sotr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
