using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace SimulacionAbejasHilos
{
    public partial class Form1 : Form
    {
        int[] vec = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int hilos = 0;


        public Form1()
        {
            InitializeComponent();
            Tiempo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hilos < 8)
            {
                Thread t1 = new Thread(new ThreadStart(Movimiento));
                t1.Start();
                hilos++;
            }
        }

        public PictureBox Abeja()
        {
            PictureBox bee = new PictureBox();
            bee.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.Bee;
            bee.BackColor = System.Drawing.Color.Transparent;
            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            bee.Location = new System.Drawing.Point(68, 114);
            bee.Size = new System.Drawing.Size(25, 22);
            bee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            bee.BringToFront();

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        this.Controls.Add(bee);
                    }
                    ));
            }
            else
            {
                this.Controls.Add(bee);
            }

            return bee;
        }

        public void Movimiento()
        {
            PictureBox bee = Abeja();
            Random rand = new Random();
            int i, x, y, sentido = 4;

            y = rand.Next(8);

            while (true)
            {
                if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                    break;

                x = rand.Next(8);
                i = 0;

                if (x == 0)
                {
                    if (bee.Location.Y > 20)
                    {
                        if (sentido == 4)
                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        else if (sentido == 2)
                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        else if (sentido == 6)
                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

                        i = 0;
                        while (i < 15 && bee.Location.Y > 20)
                        {
                            if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                break;

                            if (this.InvokeRequired)
                            {
                                this.Invoke(new MethodInvoker(
                                    delegate()
                                    {
                                        bee.Location = new System.Drawing.Point(bee.Location.X, bee.Location.Y - 6);
                                    }
                                    ));
                            }
                            else
                            {
                                bee.Location = new System.Drawing.Point(bee.Location.X, bee.Location.Y - 6);
                            }

                            i++;
                            Thread.Sleep(100);
                        }
                        sentido = 0;
                    }
                }
                else
                    if (x == 1)
                    {
                        if (bee.Location.X < 490 && bee.Location.Y > 20)
                        {
                            if (sentido == 4)
                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            else if (sentido == 2)
                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            else if (sentido == 6)
                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            i = 0;
                            while (i < 15 && bee.Location.X < 490 && bee.Location.Y > 20)
                            {
                                if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                    break;

                                if (this.InvokeRequired)
                                {
                                    this.Invoke(new MethodInvoker(
                                        delegate()
                                        {
                                            bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y - 6);
                                        }
                                        ));
                                }
                                else
                                {
                                    bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y - 6);
                                }

                                i++;
                                Thread.Sleep(100);
                            }
                            sentido = 0;
                        }
                    }
                    else
                        if (x == 2)
                        {
                            if (bee.Location.X < 490)
                            {
                                if (sentido == 0)
                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                else if (sentido == 4)
                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                else if (sentido == 6)
                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                i = 0;
                                while (i < 15 && bee.Location.X < 490)
                                {
                                    if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                        break;

                                    if (this.InvokeRequired)
                                    {
                                        this.Invoke(new MethodInvoker(
                                            delegate()
                                            {
                                                bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y);
                                            }
                                            ));
                                    }
                                    else
                                    {
                                        bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y);
                                    }

                                    i++;
                                    Thread.Sleep(100);
                                }
                                sentido = 2;
                            }
                        }
                        else
                            if (x == 3)
                            {
                                if (bee.Location.X < 490 && bee.Location.Y < 370)
                                {
                                    if (sentido == 0)
                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                    else if (sentido == 2)
                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                    else if (sentido == 6)
                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    i = 0;
                                    while (i < 15 && bee.Location.X < 490 && bee.Location.Y < 370)
                                    {
                                        if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                            break;

                                        if (this.InvokeRequired)
                                        {
                                            this.Invoke(new MethodInvoker(
                                                delegate()
                                                {
                                                    bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y + 6);
                                                }
                                                ));
                                        }
                                        else
                                        {
                                            bee.Location = new System.Drawing.Point(bee.Location.X + 6, bee.Location.Y + 6);
                                        }

                                        i++;
                                        Thread.Sleep(100);
                                    }
                                    sentido = 4;
                                }
                            }
                            else
                                if (x == 4)
                                {
                                    if (bee.Location.Y < 370)
                                    {
                                        if (sentido == 0)
                                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                        else if (sentido == 2)
                                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                        else if (sentido == 6)
                                            bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                        i = 0;
                                        while (i < 15 && bee.Location.Y < 370)
                                        {
                                            if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                                break;

                                            if (this.InvokeRequired)
                                            {
                                                this.Invoke(new MethodInvoker(
                                                    delegate()
                                                    {
                                                        bee.Location = new System.Drawing.Point(bee.Location.X, bee.Location.Y + 6);
                                                    }
                                                    ));
                                            }
                                            else
                                            {
                                                bee.Location = new System.Drawing.Point(bee.Location.X, bee.Location.Y + 6);
                                            }

                                            i++;
                                            Thread.Sleep(100);
                                        }
                                        sentido = 4;
                                    }
                                }
                                else
                                    if (x == 5)
                                    {
                                        if (bee.Location.X > 20 && bee.Location.Y < 370)
                                        {
                                            if (sentido == 0)
                                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                            else if (sentido == 2)
                                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                            else if (sentido == 6)
                                                bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                            i = 0;
                                            while (i < 15 && bee.Location.X > 20 && bee.Location.Y < 370)
                                            {
                                                if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                                    break;

                                                if (this.InvokeRequired)
                                                {
                                                    this.Invoke(new MethodInvoker(
                                                        delegate()
                                                        {
                                                            bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y + 6);
                                                        }
                                                        ));
                                                }
                                                else
                                                {
                                                    bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y + 6);
                                                }

                                                i++;
                                                Thread.Sleep(100);
                                            }
                                            sentido = 4;
                                        }
                                    }
                                    else
                                        if (x == 6)
                                        {
                                            if (bee.Location.X > 20)
                                            {
                                                if (sentido == 0)
                                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                                else if (sentido == 2)
                                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                                else if (sentido == 4)
                                                    bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                                i = 0;
                                                while (i < 15 && bee.Location.X > 20)
                                                {
                                                    if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                                        break;

                                                    if (this.InvokeRequired)
                                                    {
                                                        this.Invoke(new MethodInvoker(
                                                            delegate()
                                                            {
                                                                bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y);
                                                            }
                                                            ));
                                                    }
                                                    else
                                                    {
                                                        bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y);
                                                    }

                                                    i++;
                                                    Thread.Sleep(100);
                                                }
                                                sentido = 6;
                                            }
                                        }
                                        else
                                            if (x == 7)
                                            {
                                                if (bee.Location.X > 20 && bee.Location.Y > 20)
                                                {
                                                    if (sentido == 4)
                                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                                    else if (sentido == 2)
                                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                                    else if (sentido == 6)
                                                        bee.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                                    i = 0;
                                                    while (i < 15 && bee.Location.X > 20 && bee.Location.Y > 20)
                                                    {
                                                        if (vec[0] == 1 && bee.Location.X > 17 && bee.Location.X < 53 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[1] == 1 && bee.Location.X > 101 && bee.Location.X < 137 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[2] == 1 && bee.Location.X > 176 && bee.Location.X < 212 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[3] == 1 && bee.Location.X > 252 && bee.Location.X < 288 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[4] == 1 && bee.Location.X > 316 && bee.Location.X < 352 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[5] == 1 && bee.Location.X > 391 && bee.Location.X < 427 && bee.Location.Y > 303 && bee.Location.Y < 332 ||
                    vec[6] == 1 && bee.Location.X > 466 && bee.Location.X < 502 && bee.Location.Y > 303 && bee.Location.Y < 332)
                                                            break;

                                                        if (this.InvokeRequired)
                                                        {
                                                            this.Invoke(new MethodInvoker(
                                                                delegate()
                                                                {
                                                                    bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y - 6);
                                                                }
                                                                ));
                                                        }
                                                        else
                                                        {
                                                            bee.Location = new System.Drawing.Point(bee.Location.X - 6, bee.Location.Y - 6);
                                                        }

                                                        i++;
                                                        Thread.Sleep(100);
                                                    }
                                                    sentido = 0;
                                                }
                                            }
            }

            double x1, x2 = 68, y1, y2 = 114, deltax, deltay, direccionx, direcciony, puntox2, puntoy2, distancia, t = 0;

            x1 = bee.Location.X;
            y1 = bee.Location.Y;
            distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        bee.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.BeeP;
                    }
                    ));
            }
            else
            {
                bee.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.BeeP;
            }

            while (distancia > 2)
            {
                x1 = bee.Location.X;
                y1 = bee.Location.Y;
                deltax = x2 - x1;
                deltay = y2 - y1;
                distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

                if ((deltax / distancia) < Int32.MinValue || (deltax / distancia) > Int32.MaxValue)
                {
                    break;
                }
                else
                {
                    direccionx = (deltax / distancia);
                    direcciony = (deltay / distancia);
                    puntox2 = (x1 + direccionx * (distancia * t));
                    puntoy2 = (y1 + direcciony * (distancia * t));

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(
                            delegate()
                            {
                                if (puntox2 < Int32.MinValue || puntoy2 < Int32.MinValue)
                                    return;
                                else
                                    bee.Location = new System.Drawing.Point(Convert.ToInt32(puntox2), Convert.ToInt32(puntoy2));
                            }
                            ));
                    }
                    else
                    {
                        if (puntox2 < Int32.MinValue || puntoy2 < Int32.MinValue)
                            return;
                        else
                            bee.Location = new System.Drawing.Point(Convert.ToInt32(puntox2), Convert.ToInt32(puntoy2));
                    }
                }

                Thread.Sleep(100);
                t = t + 0.01;
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        bee.Dispose();
                    }
                    ));
            }
            else
            {
                bee.Dispose();
            }

            hilos--;
        }

        public void Flor(int x, int pos)
        {
            PictureBox flower = new PictureBox();
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {

                        flower.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.Flower;
                        flower.BackColor = System.Drawing.Color.Transparent;
                        flower.Location = new System.Drawing.Point(x, 309);
                        flower.Size = new System.Drawing.Size(72, 100);
                        flower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        this.Controls.Add(flower);
                    }
                    ));
            }
            else
            {
                flower.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.Flower;
                flower.BackColor = System.Drawing.Color.Transparent;
                flower.Location = new System.Drawing.Point(x, 309);
                flower.Size = new System.Drawing.Size(72, 100);
                flower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                this.Controls.Add(flower);
            }

            Thread.Sleep(5000);
            vec[pos] = 0;

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        flower.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.Marchita;
                        flower.Location = new System.Drawing.Point(x, 316);
                    }
                    ));
            }
            else
            {
                flower.BackgroundImage = global::SimulacionAbejasHilos.Properties.Resources.Marchita;
                flower.Location = new System.Drawing.Point(x, 316);
            }

            Thread.Sleep(1000);

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        flower.Dispose();
                    }
                    ));
            }
            else
            {
                flower.Dispose();
            }
        }

        public void Florecer()
        {
            Random rand = new Random();
            int x;

            x = rand.Next(7);

            if (x == 0 && vec[x] != 1)
            {
                vec[x] = 1;
                Flor(12, 0);
            }
            else
                if (x == 1 && vec[x] != 1)
                {
                    vec[x] = 1;
                    Flor(86, 1);
                }
                else
                    if (x == 2 && vec[x] != 1)
                    {
                        vec[x] = 1;
                        Flor(164, 2);
                    }
                    else
                        if (x == 3 && vec[x] != 1)
                        {
                            vec[x] = 1;
                            Flor(237, 3);
                        }
                        else
                            if (x == 4 && vec[x] != 1)
                            {
                                vec[x] = 1;
                                Flor(311, 4);
                            }
                            else
                                if (x == 5 && vec[x] != 1)
                                {
                                    vec[x] = 1;
                                    Flor(386, 5);
                                }
                                else
                                    if (x == 6 && vec[x] != 1)
                                    {
                                        vec[x] = 1;
                                        Flor(461, 6);
                                    }
        }

        public void Tiempo()
        {
            System.Timers.Timer tiempo;
            tiempo = new System.Timers.Timer(10000);
            tiempo.Elapsed += new ElapsedEventHandler(Temporizador);
            tiempo.Interval = 2000;
            tiempo.Enabled = true;
            GC.KeepAlive(tiempo);
        }

        private void Temporizador(object source, ElapsedEventArgs e)
        {
            Florecer();
        }
    }
}

/*
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        this.Controls.Add(bee);
                    }
                    ));
            }
            else
            {
                this.Controls.Add(bee);
            }
 
            bool overlapped = p1.IntersectsWith(p2);


*/