using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        int correctAnswer; 
        int countCorrectAnswer; 
        int percent;

        int totalQuestion = 16; 
        int questionNumber = 1; 

        public string name;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void ClickButton(object sender, EventArgs e)
        {
            Guna2Button guna2Button = (Guna2Button)sender; 

            int buttonTag = Convert.ToInt32(guna2Button.Tag); 

            if (buttonTag == correctAnswer)
            {
                MessageBox.Show("Вы ответили правильно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                countCorrectAnswer++;
            }
            else 
            {
                MessageBox.Show("Вы ответили не правильно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(questionNumber == totalQuestion)
            {
                percent = (int)Math.Round((double)(countCorrectAnswer * 100) / totalQuestion); 

                MessageBox.Show($"{name}, вы молодец!" + " \r" +
                    "Тест закончился:" + " \r" +
                    "Ваше количество правильных ответов -> " + countCorrectAnswer + " \r" +
                    "Ваш процент -> " + percent + "%" + " \r" +
                    "Нажмите ОК, чтобы играть снова", "Сообщение"
                    );

                countCorrectAnswer = 0;
                questionNumber = 0;

                //askQuestion(questionNumber);

                var myForm = new Form2();
                myForm.Show();
                Hide();
            }

            

            questionNumber++;
            askQuestion(questionNumber);
        }
         
        private void askQuestion(int questionNumberNew)
        {
                switch (questionNumberNew)
                {
                    case 1:

                        guna2TextBox3.Text = "1. С помощью чего языки cценариев выполняют задачи?";

                        guna2Button1.Text = "Интерпретатор";
                        guna2Button2.Text = "Компилятор";
                        guna2Button3.Text = "Криминатор";
                        guna2Button4.Text = "Санкватор";
                        
                        correctAnswer = 1;
   
                     break;


                    case 2:

                    guna2TextBox3.Text = "2. Какой вид относится к языкам сценариев?" + " \r\n";

                        guna2Button1.Text = "Гипертекстовой";
                        guna2Button2.Text = "Поралаксальный";
                        guna2Button3.Text = "Командно-сценарные";
                        guna2Button4.Text = "Каскадный";

                        correctAnswer = 3; // buttob1 

                        break;

                    case 3:

                    guna2TextBox3.Text = "3. Как по-другому называются языки сценариев?";

                        guna2Button1.Text = "Скриптовыйе";
                        guna2Button2.Text = "Гипертекстовые ";
                        guna2Button3.Text = "Интеллектуальные";
                        guna2Button4.Text = "Неполнофункциональные";

                        correctAnswer = 1; // buttob1 

                        break;

                    case 4:

                    guna2TextBox3.Text = "4. Какой из фреймворков написан на языке JavaScript?";

                        guna2Button1.Text = "Django";
                        guna2Button2.Text = "Vue";
                        guna2Button3.Text = "Tornado";
                        guna2Button4.Text = "CodeIgniter";

                        correctAnswer = 2; // buttob1 

                        break;

                    case 5:

                    guna2TextBox3.Text = "5. Какой из фреймворков написан на языке Python?";

                        guna2Button1.Text = "Laravel";
                        guna2Button2.Text = "TurboGears";
                        guna2Button3.Text = "Dancer";
                        guna2Button4.Text = "Mojolicious";

                        correctAnswer = 2; // buttob1 

                        break;

                    case 6:

                    guna2TextBox3.Text = "6. К какому типу языков сценариев относится язык AppleScript?";

                        guna2Button1.Text = "Гипертекстовые" + " \r" + "языки разметки";
                        guna2Button2.Text = "Командно-" + " \r" + "сценарные языки";
                        guna2Button3.Text = "Прикладные языки" + " \r" + "сценариев";
                        guna2Button4.Text = "Языки сценариев" + " \r" + "общего назначения";

                        correctAnswer = 2; // buttob1 

                        break;

                    case 7:

                    guna2TextBox3.Text = "7. Какой на сегодняшний день язык сценариев является самым популярны среди разработчиков?";

                        guna2Button1.Text = "JavaScript";
                        guna2Button2.Text = "Python";
                        guna2Button3.Text = "PHP";
                        guna2Button4.Text = "PowerShell";

                        correctAnswer = 1; // buttob1 

                        break;

                    case 8:

                    guna2TextBox3.Text = "8. Когда появился сценарный язык программирования PHP?";

                        guna2Button1.Text = "1974";
                        guna2Button2.Text = "1991";
                        guna2Button3.Text = "1995";
                        guna2Button4.Text = "1983";

                        correctAnswer = 3; // buttob1 
                        break;

                    case 9:

                    guna2TextBox3.Text = "9. Что относится к языку сценариев?";

                        guna2Button1.Text = "C#";
                        guna2Button2.Text = "Lua";
                        guna2Button3.Text = "C++";
                        guna2Button4.Text = "HTML";

                        correctAnswer = 2; // buttob1 
                        break;

                    case 10:

                    guna2TextBox3.Text = "10. Когда появился сценарный язык программирования Python?";

                        guna2Button1.Text = "1994";
                        guna2Button2.Text = "1993";
                        guna2Button3.Text = "1972";
                        guna2Button4.Text = "1991";

                        correctAnswer = 4; // buttob1 
                        break;

                    case 11:

                    guna2TextBox3.Text = "11. К какому типу языков сценариев относится язык PHP?";

                        guna2Button1.Text = "Язык гипертекстовой" + "\r" + "разметки";
                        guna2Button2.Text = "Командно-сценарные" + "\r" + "языки";
                        guna2Button3.Text = "Прикладные языки" + "\r" + "сценариев";
                        guna2Button4.Text = "Языки сценарий" + "\r" + "общего назначения";

                        correctAnswer = 4; // buttob1 

                        break;
                case 12:

                    guna2TextBox3.Text = "12. Как по-другому называются прикладные языки сценариев?";

                    guna2Button1.Text = "Специальные языки" + "\r" + "сценариев";
                    guna2Button2.Text = "Языки сценарий" + "\r" + "общего назначения";
                    guna2Button3.Text = "Встроенные" + "\r" + "языки сценариев";
                    guna2Button4.Text = "Язык гипертекстовой" +"\r" +  "разметки";

                    correctAnswer = 3; // buttob1 

                    break;

                case 13:

                    guna2TextBox3.Text = "13. Какой язык сценариев лучше подходит для разработки браузерных игр?";

                    guna2Button1.Text = "C#";
                    guna2Button2.Text = "C++";
                    guna2Button3.Text = "Perl";
                    guna2Button4.Text = "JavaScript";

                    correctAnswer = 4; // buttob1 

                    break;

                case 14:

                    guna2TextBox3.Text = "14. Какой язык программирования не является языком сценариев?";

                    guna2Button1.Text = "C#";
                    guna2Button2.Text = "JavaScript";
                    guna2Button3.Text = "Perl";
                    guna2Button4.Text = "PowerShell";

                    correctAnswer = 1; // buttob1 

                    break;

                case 15:

                    guna2TextBox3.Text = "15. Какой язык сценариев подходит для разработки торговых роботов?";

                    guna2Button1.Text = "PowerShell";
                    guna2Button2.Text = "MQL4";
                    guna2Button3.Text = "AppleScript";
                    guna2Button4.Text = "Bash";

                    correctAnswer = 2; // buttob1 

                    break;

                case 16:

                    guna2TextBox3.Text = "16. Когда появился сценарный язык программирования JavaScript?";

                    guna2Button1.Text = "1991";
                    guna2Button2.Text = "1976";
                    guna2Button3.Text = "1995";
                    guna2Button4.Text = "1987";

                    correctAnswer = 3; // buttob1 

                    break;
            }
           
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
