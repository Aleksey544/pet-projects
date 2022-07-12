//МЕТОДЫ ОПТИМИЗАЦИИ, РАЗРАБОТАЛ КУЗУБ АЛЕКСЕЙ
using System;
using System.Windows.Forms;

namespace OptimizationMethods
{
    public partial class OneDimensionalSearchMethodsForm : Form
    {
        public OneDimensionalSearchMethodsForm()
        {
            InitializeComponent();
        }

        //ПОСТРОЕНИЕ ГРАФИКА ФУНКЦИИ
        //Очистка графика и данных расчётов на форме
        private void Clear()
        {
            for(int i = 0; i < 4; i++)
                GraphicChart.Series[i].Points.Clear();
            
            GraphicChart.Titles[0].Text = "";
            TableListBox.Items.Clear();
        }

        //Инициализация математической функции
        private double InitialMathFunction(double X)
        {
            double A = Convert.ToDouble(ATextBox.Text);
            double B = Convert.ToDouble(BTextBox.Text);
            double C = Convert.ToDouble(CTextBox.Text);
            double Y = A * Math.Pow(X, 2) + B * X + C;
            GraphicChart.Titles[0].Text = $"График функции f(X) = {A} * X^2 + {B} * X + {C}";
            return Y;
        }

        //Построение графика
        private void DrawMathFunctionGraphic(double X, double H, int P)
        {
            Clear();
            double f;

            if (GraphicDirectionRightRadioButton.Checked)
            {
                for (int i = 0; i < P; i++)
                {
                    f = InitialMathFunction(X);
                    GraphicChart.Series[0].Points.AddXY(X, f);
                    X += H;
                }
            }
            else if (GraphicDirectionLeftRadioButton.Checked)
            {
                for (int i = 0; i < P; i++)
                {
                    f = InitialMathFunction(X);
                    GraphicChart.Series[0].Points.AddXY(X, f);
                    X -= H;
                }
            }
        }

        //Построение точек графика методами одномерного поиска
        private void DrawMethodsPoints(double u, double fu, double v, double fv, double l, int i)
        {
            if (l != -1)
                TableListBox.Items.Add($"Длина отрезка = {l}");

            TableListBox.Items.Add($"u({i}) = {u}");
            TableListBox.Items.Add($"fu({i}) = {fu}");
            TableListBox.Items.Add($"v({i}) = {v}");
            TableListBox.Items.Add($"fv({i}) = {fv}");
            GraphicChart.Series[2].Points.AddXY(u, fu);
            GraphicChart.Series[2].Points.AddXY(v, fv);
        }

        //МЕТОДЫ ОДНОМЕРНОГО ПОИСКА
        //Метод Свенна
        private void SwennMethodStart(double H, double X0, int P, out double a, out double b, out double c)
        {
            double[] x = new double[60];
            double[] f = new double[60];
            double[] h = new double[60];
            h[1] = H;
            int k = 0;
            a = 0; //начальная граница
            b = 0; //конечная граница
            c = 0; //внутр. точка

            DrawMathFunctionGraphic(X0, H, P);
            TableListBox.Items.Add("МЕТОД СВЕННА:");
            TableListBox.Items.Add($"Значения ф-ии с шагом h: ");

            x[0] = X0;
            f[0] = InitialMathFunction(x[0]);
            GraphicChart.Series[1].Points.AddXY(x[0], f[0]);
            TableListBox.Items.Add($"x(0) = {x[0]}");
            TableListBox.Items.Add($"f(0) = {f[0]}");

            x[1] = x[0] + h[1];
            f[1] = InitialMathFunction(x[1]);
            GraphicChart.Series[1].Points.AddXY(x[1], f[1]);
            TableListBox.Items.Add($"h(1) = {h[1]}");
            TableListBox.Items.Add($"x(1) = {x[1]}");
            TableListBox.Items.Add($"f(1) = {f[1]}");


            if (f[1] < f[0])
            {
                while (f[k + 1] < f[k])
                {
                    k++;
                    h[k + 1] = Math.Pow(2, k) * h[1];
                    x[k + 1] = x[k] + h[k + 1];
                    f[k + 1] = InitialMathFunction(x[k + 1]);
                    GraphicChart.Series[1].Points.AddXY(x[k + 1], f[k + 1]);
                    TableListBox.Items.Add($"h({k + 1}) = {h[k + 1]}");
                    TableListBox.Items.Add($"x({k + 1}) = {x[k + 1]}");
                    TableListBox.Items.Add($"f({k + 1}) = {f[k + 1]}");
                }

                a = x[k - 1];
                b = x[k + 1];
                c = x[k];
                TableListBox.Items.Add("Интервал неопределённости:");
                TableListBox.Items.Add($"Начал. граница a = x({k - 1}) = {a}");
                TableListBox.Items.Add($"Конеч. граница b = x({k + 1}) = {b}");
                TableListBox.Items.Add($"Внутр. точка с = x({k}) = {c}");
            }
            else if (f[1] >= f[0])
            {
                h[2] = -h[1];
                x[2] = x[0] + h[2];
                f[2] = InitialMathFunction(x[2]);
                GraphicChart.Series[1].Points.AddXY(x[2], f[2]);
                TableListBox.Items.Add($"h(2) = {h[2]}");
                TableListBox.Items.Add($"x(2) = {x[2]}");
                TableListBox.Items.Add($"f(2) = {f[2]}");
                k++;

                if (f[2] < f[0])
                {
                    while (f[k + 1] < f[k])
                    {
                        k++;
                        h[k + 1] = -(Math.Pow(2, k - 1) * h[1]);
                        x[k + 1] = x[k] + h[k + 1];
                        f[k + 1] = InitialMathFunction(x[k + 1]);
                        GraphicChart.Series[1].Points.AddXY(x[k + 1], f[k + 1]);
                        TableListBox.Items.Add($"h({k + 1}) = {h[k + 1]}");
                        TableListBox.Items.Add($"x({k + 1}) = {x[k + 1]}");
                        TableListBox.Items.Add($"f({k + 1}) = {f[k + 1]}");
                    }
                }

                a = x[k + 1];
                b = x[k - 1];
                c = x[k];
                TableListBox.Items.Add("Интервал неопределённости:");
                TableListBox.Items.Add($"Начал. граница a = x({k + 1}) = {a}");
                TableListBox.Items.Add($"Конеч. граница b = x({k - 1}) = {b}");
                TableListBox.Items.Add($"Внутр. точка с = x({k}) = {c}");
            }
        }

        //Кол-во итераций: дихотомии - 30, отрезка пополам - 22-25, золотого сечения - 20-23, адаптации шага - 18-20
        //Метод Дихотомии
        private void DichotomiesMethodStart(double H, double X0, double E, int P)
        {
            SwennMethodStart(H, X0, P, out double a, out double b, out double g);
            TableListBox.Items.Add("МЕТОД ДИХОТОМИИ:");

            int i = 0;
            double l = b - a; //длина между внутр. точками интервала неопределённости
            double c = (a + b) / 2; //срединная точка
            double u = c - E; //1-я внутр. точка
            double fu = InitialMathFunction(u);
            double v = c + E; //2-я внутр. точка
            double fv = InitialMathFunction(v);
            DrawMethodsPoints(u, fu, v, fv, l, i);
            i++;

            if (fu < fv)
                b = v;
            else
                a = u;

            while (l > E * 2.1)
            {
                l = b - a;
                c = (a + b) / 2;
                u = c - E;
                fu = InitialMathFunction(u);
                v = c + E;
                fv = InitialMathFunction(v);
                DrawMethodsPoints(u, fu, v, fv, l, i);
                i++;

                if (fu < fv)
                    b = v;
                else
                    a = u;
            }

            u = (a + b) / 2;
            fu = InitialMathFunction(u);
            TableListBox.Items.Add($"x(min) = {u}");
            TableListBox.Items.Add($"f(min) = {fu}");
            GraphicChart.Series[3].Points.AddXY(u, fu);
        }

        //Метод деления отрезка пополам
        private void BisectionMethodStart(double H, double X0, double E, int P)
        {
            SwennMethodStart(H, X0, P, out double a, out double b, out double g);
            TableListBox.Items.Add("МЕТОД ДЕЛЕНИЯ ОТРЕЗКА ПОПОЛАМ:");

            int i = 0;
            double l = b - a;
            double c = (a + b) / 2;
            double u = u = (a + c) / 2;
            double fu = InitialMathFunction(u);
            double fc = InitialMathFunction(c);
            double v, fv;
            DrawMethodsPoints(u, fu, c, fc, l, i);
            i++;

            while (c - a > E)
            {
                l = b - a;
                u = (a + c) / 2;
                fu = InitialMathFunction(u);

                if (fu < fc)
                {
                    b = c;
                    c = u;
                    fc = fu;
                    u = (a + c) / 2;
                    fu = InitialMathFunction(u);
                }
                else
                {
                    v = (c + b) / 2;
                    fv = InitialMathFunction(v);

                    if (fv < fc)
                    {
                        a = u;
                        c = v;
                        fc = fv;
                    }
                    else
                    {
                        a = u;
                        b = v;
                    }
                }

                DrawMethodsPoints(u, fu, c, fc, l, i);
                i++;
            }

            TableListBox.Items.Add($"x(min) = {c}");
            TableListBox.Items.Add($"f(min) = {fc}");
            GraphicChart.Series[3].Points.AddXY(c, fc);
        }

        //Метод золотого сечения
        private void GoldenSectionMethodStart(double H, double X0, double E, int P)
        {
            SwennMethodStart(H, X0, P, out double a, out double b, out double g);
            TableListBox.Items.Add("МЕТОД ЗОЛОТОГО СЕЧЕНИЯ:");

            int i = 0;
            double t = 0.5 * (Math.Sqrt(5) - 1);
            double l = b - a;
            double h = t * l;
            double u = b - h;
            double fu = InitialMathFunction(u);
            double v = a + h;
            double fv = InitialMathFunction(v);
            

            while (l > E)
            {
                if (fu > fv)
                {
                    a = u;
                    u = v;
                    fu = fv;
                    l = b - a;
                    v = a + t * l;
                    fv = InitialMathFunction(v);
                }
                else
                {
                    b = v;
                    v = u;
                    fv = fu;
                    l = b - a;
                    u = b - t * l;
                    fu = InitialMathFunction(u);
                }

                DrawMethodsPoints(u, fu, v, fv, l, i);
                i++;
            }

            if (fv < fu)
            {
                u = v;
                fu = fv;
            }

            TableListBox.Items.Add($"x(min) = {u}");
            TableListBox.Items.Add($"f(min) = {fu}");
            GraphicChart.Series[3].Points.AddXY(u, fu);
        }

        //Метод адаптации шага
        private void StepAdaptationMethodStart(double H, double X0, double E, int P)
        {
            DrawMathFunctionGraphic(X0, H, P);
            TableListBox.Items.Add("МЕТОД АДАПТАЦИИ ШАГА:");

            int i = 0;
            double r = 0;
            double u = X0;
            double fu = InitialMathFunction(u);
            double v, fv;

            while (Math.Abs(H) > E)
            {
                v = u + H;
                fv = InitialMathFunction(v);

                if (fv > fu)
                {
                    if (r == 2)
                        r = 0.25;
                    else
                        r = -0.5;
                }
                else
                {
                    u = v;
                    fu = fv;

                    if (r >= 0.5)
                        r = 2;
                    else
                        r = 0.5;
                }

                H = H * r;
                DrawMethodsPoints(u, fu, v, fv, -1, i);
                i++;
            }

            TableListBox.Items.Add($"x(min) = {u}");
            TableListBox.Items.Add($"f(min) = {fu}");
            GraphicChart.Series[3].Points.AddXY(u, fu);
        }

        //Метод квадратичной интерполяции с 3-мя точками
        private void QuadraticInterpolationMethodStart(double H, double X0, double E, int P)
        {
            SwennMethodStart(H, X0, P, out double a, out double b, out double x);
            TableListBox.Items.Add("МЕТОД КВАДРАТИЧНОЙ ");
            TableListBox.Items.Add("ИНТЕРПОЛЯЦИИ С 3-МЯ ТОЧКАМИ: ");

            int i = 0;
            double fa = InitialMathFunction(a);
            double fb = InitialMathFunction(b);
            double fx = InitialMathFunction(x);
            double p = (x - a) * (fb - fx);
            double q = (b - x) * (fa - fx);
            double s = p + q;
            double y = 0, fy;

            while (s > 0)
            {
                if (Math.Abs(x - y) >= E)
                {
                    p = (x - a) * (fb - fx);
                    q = (b - x) * (fa - fx);
                    s = p + q;
                    y = 0.5 * (p * (a + x) + q * (b + x)) / s;
                    
                    if (y > a || y < b)
                    {
                        fy = InitialMathFunction(y);

                        if (fy > fx)
                        {
                            if (y < x)
                            {
                                a = y;
                                fa = fy;
                            }
                        }
                        else if (y < x)
                        {
                            b = x;
                            fb = fx;
                            x = y;
                            fx = fy;
                        }
                        else if (fy <= fx || y >= x)
                        {
                            a = x;
                            fa = fx;
                            x = y;
                            fx = fy;
                        }
                        else
                        {
                            if (y < x)
                            {
                                a = y;
                                fa = fy;
                            }
                            else
                            {
                                b = y;
                                fb = fy;
                            }
                        }
                    }
                    else
                        break;
                }
                else
                {
                    if (fa < fx)
                    {
                        x = a;
                        fx = fa;
                    }

                    if (fb < fx)
                    {
                        x = b;
                        fx = fb;
                    }

                    break;
                }

                DrawMethodsPoints(a, fa, b, fb, -1, i);
                i++;
            }

            TableListBox.Items.Add($"x(min) = {x}");
            TableListBox.Items.Add($"f(min) = {fx}");
            GraphicChart.Series[3].Points.AddXY(x, fx);
        }

        //ЧАСТЬ ГРАФИЧЕСКОГО ИНТЕРФЕЙСА ПОЛЬЗОВАТЕЛЯ
        private void OptimizationMethodsStart()
        {
            try
            {
                //Конвертация string-значений, введённых пользователем на форме, в double
                double A = Convert.ToDouble(ATextBox.Text); //первый коэффициент квадратичной функции
                double B = Convert.ToDouble(BTextBox.Text); //второй коэффициент квадратичной функции
                double C = Convert.ToDouble(CTextBox.Text); //свободный член квадратичной функции
                double H = Convert.ToDouble(hTextBox.Text); //шаг
                double X0 = Convert.ToDouble(X0TextBox.Text); //начальная точка
                double E = Convert.ToDouble(eTextBox.Text); //погрешность
                int P = Convert.ToInt32(pTextBox.Text); //кол-во точек графика

                if (P < 1 || H <= 0)
                {
                    MessageBox.Show("Шаг и кол-во точек графика должны быть положительными!", "Ошибка!");
                    return;
                }

                if (A <= 0)
                {
                    MessageBox.Show("Первый коэффициент квадратичной функции должен быть положительным!", "Ошибка!");
                    return;
                }

                //Вызов выбранного пользователем на форме метода оптимизации
                if (SwennMethodRadioButton.Checked)
                    SwennMethodStart(H, X0, P, out double a, out double b, out double c);
                else if (DichotomiesMethodRadioButton.Checked)
                    DichotomiesMethodStart(H, X0, E, P);
                else if (BisectionMethodRadioButton.Checked)
                    BisectionMethodStart(H, X0, E, P);
                else if (GoldenSectionMethodRadioButton.Checked)
                    GoldenSectionMethodStart(H, X0, E, P);
                else if (StepAdaptationMethodRadioButton.Checked)
                    StepAdaptationMethodStart(H, X0, E, P);
                else if (QuadraticInterpolationMethodRadioButton.Checked)
                    QuadraticInterpolationMethodStart(H, X0, E, P);
            }
            catch (Exception)
            {
                MessageBox.Show("Числа введены некорректно!", "Ошибка!");
                return;
            }
        }

        private void BuildGraphicButton_Click(object sender, EventArgs e)
        {
            OptimizationMethodsStart();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void OneDimensionalSearchMethodsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                OptimizationMethodsStart();
        }
    }
}
