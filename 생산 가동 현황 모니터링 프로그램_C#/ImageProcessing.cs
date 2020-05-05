using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using OpenCvSharp;


namespace 생산_가동_현황_모니터링_프로그램
{
    public partial class ImageProcessing : MetroForm
    {
        public ImageProcessing()
        {
            InitializeComponent();
        }
        private JoinForm joinForm = null;
        public ImageProcessing(JoinForm form)
        {
            InitializeComponent();
            this.joinForm = form;
        }

        private UpdateForm updateForm = null;
        public ImageProcessing(UpdateForm form)
        {
            InitializeComponent();
            this.updateForm = form;
        }

        private SelectUpdateForm selectUpdateForm = null;
        public ImageProcessing(SelectUpdateForm form)
        {
            InitializeComponent();
            this.selectUpdateForm = form;
        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {
            // 폼 위치 중앙
            this.Location = new System.Drawing.Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
            );
            groupBox1.Location = new System.Drawing.Point(
                this.Size.Width / 2 - groupBox1.Size.Width / 2,
                this.Size.Height / 2 - groupBox1.Size.Height / 2 + 20
            );
            // 그룹박스 테두리 및 배경 색 변경
            groupBox1.Paint += PaintBorderlessGroupBox;
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        byte[,,] inImage, outImage;
        public static int inW, inH, outW, outH;
        string filename = "";
        Bitmap paper;

        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int xPos, yPos, r, g, b, height, width;
            string sql = "";
            try
            {
                if (joinForm.tb_userID.Text != "")
                {
                    for (int i = 0; i < inW; i++)
                    {
                        for (int k = 0; k < inH; k++)
                        {
                            xPos = i;
                            yPos = k;
                            r = outImage[0, i, k];
                            g = outImage[1, i, k];
                            b = outImage[2, i, k];
                            height = inH;
                            width = inW;

                            conn = new MySqlConnection(strConn);
                            conn.Open();
                            cmd = new MySqlCommand("", conn);
                            if (i == 0 && k == 0)
                            {
                                sql = "INSERT INTO user_image VALUES ('";
                                sql += joinForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + "," + height + "," + width + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                sql = "INSERT INTO user_image (fid, xPos, yPos, r, g, b) VALUES ('";
                                sql += joinForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                    }
                }
            }
            catch
            {

            }
            try
            {
                if (updateForm.tb_userID.Text != "")
                {
                    UpdateForm.updateState = true;

                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    sql = "SELECT * FROM user_image WHERE fid='" + updateForm.tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    int n = 0;
                    while (reader.Read())
                    {
                        Array.Resize(ref UpdateForm.prexPos, UpdateForm.prexPos.Length + 1);
                        Array.Resize(ref UpdateForm.preyPos, UpdateForm.preyPos.Length + 1);
                        Array.Resize(ref UpdateForm.prer, UpdateForm.prer.Length + 1);
                        Array.Resize(ref UpdateForm.preg, UpdateForm.preg.Length + 1);
                        Array.Resize(ref UpdateForm.preb, UpdateForm.preb.Length + 1);
                        UpdateForm.prexPos[n] = int.Parse(reader["xPos"].ToString());
                        UpdateForm.preyPos[n] = int.Parse(reader["yPos"].ToString());
                        UpdateForm.prer[n] = int.Parse(reader["r"].ToString());
                        UpdateForm.preg[n] = int.Parse(reader["g"].ToString());
                        UpdateForm.preb[n] = int.Parse(reader["b"].ToString());
                        if (n == 0)
                        {
                            UpdateForm.preheight = int.Parse(reader["height"].ToString());
                            UpdateForm.prewidth = int.Parse(reader["width"].ToString());
                        }
                        n++;
                    }
                    reader.Close();
                    sql = "DELETE FROM user_image WHERE fid='" + updateForm.tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    for (int i = 0; i < inW; i++)
                    {
                        for (int k = 0; k < inH; k++)
                        {
                            xPos = i;
                            yPos = k;
                            r = outImage[0, i, k];
                            g = outImage[1, i, k];
                            b = outImage[2, i, k];
                            height = inH;
                            width = inW;

                            conn = new MySqlConnection(strConn);
                            conn.Open();
                            cmd = new MySqlCommand("", conn);

                            if (i == 0 && k == 0)
                            {
                                sql = "INSERT INTO user_image VALUES ('";
                                sql += updateForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + "," + height + "," + width + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                sql = "INSERT INTO user_image (fid, xPos, yPos, r, g, b) VALUES ('";
                                sql += updateForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }

                            conn.Close();
                        }
                    }
                }
            }
            catch
            {

            }
            try
            {
                if (selectUpdateForm.tb_userID.Text != "")
                {
                    SelectUpdateForm.selectUpdateState = true;

                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    sql = "SELECT * FROM user_image WHERE fid='" + selectUpdateForm.tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    int n = 0;
                    while (reader.Read())
                    {
                        Array.Resize(ref SelectUpdateForm.prexPos, SelectUpdateForm.prexPos.Length + 1);
                        Array.Resize(ref SelectUpdateForm.preyPos, SelectUpdateForm.preyPos.Length + 1);
                        Array.Resize(ref SelectUpdateForm.prer, SelectUpdateForm.prer.Length + 1);
                        Array.Resize(ref SelectUpdateForm.preg, SelectUpdateForm.preg.Length + 1);
                        Array.Resize(ref SelectUpdateForm.preb, SelectUpdateForm.preb.Length + 1);
                        SelectUpdateForm.prexPos[n] = int.Parse(reader["xPos"].ToString());
                        SelectUpdateForm.preyPos[n] = int.Parse(reader["yPos"].ToString());
                        SelectUpdateForm.prer[n] = int.Parse(reader["r"].ToString());
                        SelectUpdateForm.preg[n] = int.Parse(reader["g"].ToString());
                        SelectUpdateForm.preb[n] = int.Parse(reader["b"].ToString());
                        if (n == 0)
                        {
                            SelectUpdateForm.preheight = int.Parse(reader["height"].ToString());
                            SelectUpdateForm.prewidth = int.Parse(reader["width"].ToString());
                        }
                        n++;
                    }
                    reader.Close();
                    sql = "DELETE FROM user_image WHERE fid='" + selectUpdateForm.tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    for (int i = 0; i < inW; i++)
                    {
                        for (int k = 0; k < inH; k++)
                        {
                            xPos = i;
                            yPos = k;
                            r = outImage[0, i, k];
                            g = outImage[1, i, k];
                            b = outImage[2, i, k];
                            height = inH;
                            width = inW;

                            conn = new MySqlConnection(strConn);
                            conn.Open();
                            cmd = new MySqlCommand("", conn);

                            if (i == 0 && k == 0)
                            {
                                sql = "INSERT INTO user_image VALUES ('";
                                sql += selectUpdateForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + "," + height + "," + width + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                sql = "INSERT INTO user_image (fid, xPos, yPos, r, g, b) VALUES ('";
                                sql += selectUpdateForm.tb_userID.Text + "'," + xPos + "," + yPos + ",";
                                sql += r + "," + g + "," + b + ")";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }

                            conn.Close();
                        }
                    }
                }
            }
            catch
            {

            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        /// <summary>
        /// 파일이 없는 상태에서 메뉴를 선택 했을 경우 발생되는 함수
        /// </summary>
        /// <returns></returns>
        private bool CheckOpen()
        {
            if (filename.Length <= 0 || filename is null)
            {
                MessageBox.Show("파일을 먼저 열어야 합니다.");
                return false;
            }
            return true;
        }

        /// <summary>
        ///  OpenCV
        /// </summary>
        Mat inCvImage, outCvImage;
        private void Cv2ToOutImage()
        {
            // Cv2 출력 --> 내 코드로 출력
            outH = outCvImage.Height;
            outW = outCvImage.Width;
            outImage = new byte[3, outH, outW];
            for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                {
                    var c = outCvImage.At<Vec3b>(i, k);
                    outImage[0, i, k] = c.Item2;
                    outImage[1, i, k] = c.Item1;
                    outImage[2, i, k] = c.Item0;
                }
            DisplayImage();
        }

        /// <summary>
        /// DisplayImage 함수
        /// </summary>
        private void DisplayImage()
        {
            // Form 및 pictureBox 크기 조절
            int tempW = 0;
            if (outW < inW)
                tempW = inW;
            else
                tempW = outW;
            this.Size = new System.Drawing.Size(inH + outH + 70, tempW + 200);
            pb_Image1.Size = new System.Drawing.Size(inH, inW);
            pb_Image2.Size = new System.Drawing.Size(outH, outW);
            groupBox1.Size = new System.Drawing.Size(inH + outH + 40, inW + 150);
            btn_OK.Location = new System.Drawing.Point(inW - 65, inH + 60);
            btn_Cancel.Location = new System.Drawing.Point(outW + 30, outH + 60);

            // 출력될 이미지의 각각의 픽셀값 저장
            Color c;
            int r, g, b;
            paper = new Bitmap(inH, inW);
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    r = inImage[0, i, k];
                    g = inImage[1, i, k];
                    b = inImage[2, i, k];
                    c = Color.FromArgb(r, g, b);
                    paper.SetPixel(i, k, c);
                }
            pb_Image1.Image = paper;
            pb_Image1.Location = new System.Drawing.Point(10, 40);
            paper = new Bitmap(outH, outW);
            for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                {
                    r = outImage[0, i, k];
                    g = outImage[1, i, k];
                    b = outImage[2, i, k];
                    c = Color.FromArgb(r, g, b);
                    paper.SetPixel(i, k, c);
                }
            pb_Image2.Image = paper;
            pb_Image2.Location = new System.Drawing.Point(inH + 30, 40);
        }

        /// <summary>
        /// 화소점 동일이미지 알고리즘
        /// </summary>
        private void Equal()
        {
            outH = inH; outW = inW;
            outImage = new byte[3, outH, outW];
            for (int rgb = 0; rgb < 3; rgb++)
                for (int i = 0; i < outH; i++)
                    for (int k = 0; k < outW; k++)
                        outImage[rgb, i, k] = inImage[rgb, i, k];
            DisplayImage();
        }

        /// <summary>
        /// 열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "";
            ofd.Filter = "Color FIle(*.png;*.jpg;*.bmp;*.tif) | *.png;*.jpg;*.bmp;*.tif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                // 파일 --> OpenCV Matrix
                inCvImage = Cv2.ImRead(filename);
                // OpenCV Matrix 좌우 정렬
                Cv2.Transpose(inCvImage, inCvImage);
                //** 중요 ** --> 영상크기  및 메모리 할당
                inH = inCvImage.Height;
                inW = inCvImage.Width;
                inImage = new byte[3, inH, inW];
                // OpenCV Matrix --> 배열로 값을 로딩하기
                for (int i = 0; i < inH; i++)
                    for (int k = 0; k < inW; k++)
                    {
                        var c = inCvImage.At<Vec3b>(i, k);
                        inImage[0, i, k] = c.Item2;
                        inImage[1, i, k] = c.Item1;
                        inImage[2, i, k] = c.Item0;
                    }
                Equal();
            }
        }

        /// <summary>
        /// 블러링
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 블러링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 알고리즘에 의해서 outCvImage의 크기를 결정
            int oH, oW;
            oH = inCvImage.Height;
            oW = inCvImage.Width;
            outCvImage = new Mat();

            Cv2.Blur(inCvImage, outCvImage, new OpenCvSharp.Size(15, 15));
            Cv2ToOutImage();
        }


        private void 흑백ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 알고리즘에 의해서 outCvImage의 크기를 결정
            int oH, oW;
            oH = inCvImage.Height;
            oW = inCvImage.Width;
            outCvImage = new Mat();

            Cv2.CvtColor(inCvImage, outCvImage, ColorConversionCodes.BGR2GRAY);
            Cv2ToOutImage();
        }

        private void 감마변환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 알고리즘에 의해서 outCvImage의 크기를 결정
            int oH, oW;
            oH = inCvImage.Height;
            oW = inCvImage.Width;
            outCvImage = new Mat();

            double gamma_value = 4.0;
            byte[] lut = new byte[256];
            for (int i = 0; i < lut.Length; i++)
            {
                lut[i] = (byte)(Math.Pow(i / 255.0, 1.0 / gamma_value) * 255.0);
            }
            Cv2.LUT(inCvImage, lut, outCvImage);
            Cv2ToOutImage();
        }
    }
}
