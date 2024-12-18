using System;
using System.Numerics;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace deneme3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer diamondTimer;
        private bool isDiamondVisible;

        private System.Windows.Forms.Timer rockTimer;
        private bool isrockVisible;
        public Form1()
        {
            InitializeComponent();
            lbl_over.Hide();
            rock.Hide();
            diamond.Hide();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            // Diamond görünürlük zamanlayıcısını başlat
            diamondTimer = new System.Windows.Forms.Timer();
            diamondTimer.Interval = 10000; // 10 saniyede bir diamond'ı göster ya da gizle
            diamondTimer.Tick += DiamondTimer_Tick;
            diamondTimer.Start();

            isDiamondVisible = false; // Başlangıçta diamond gizli

            // Rock görünürlük zamanlayıcısını başlat
            rockTimer = new System.Windows.Forms.Timer();
            rockTimer.Interval = 15000; // 15 saniyede bir diamond'ı göster ya da gizle
            rockTimer.Tick += RockTimer_Tick;
            rockTimer.Start();
            isrockVisible = false; // Başlangıçta diamond gizli
        }

        bool up, down, left, right, space;
        string bulletDirection = "right";


        int score = 0;
        int fastEnemyScore = 10;  // Hızlı düşman öldüğünde 10 puan
        int basicEnemyScore = 5;  // Temel düşman öldüğünde 5 puan
        int bossEnemyScore = 30;  // Boss düşman öldüğünde 50 puan
        int strongEnemyScore = 20;  // Güçlü düşman öldüğünde 20 puan

        //düşman canları
        int fastEnemyHealth = 2;  // Hızlı düşman 3 can
        int basicEnemyHealth = 1;  // Temel düşman 2 can
        int bossEnemyHealth = 4;  // Boss düşman 5 can
        int strongEnemyHealth = 3;  // Güçlü düşman 4 can

        int playerHealth = 100;

        int level = 1;
        int levelThreshold = 300;
        int enemySpeed = 5;




        Random rnd = new Random();
        int enemyBulletInterval;


        // Oyuncunun sağlığını azaltan fonksiyon
        void DeductPlayerHealth(int damage)
        {
            playerHealth -= damage;
            if (playerHealth <= 0)
            {
                EndGame();  // Oyuncunun sağlığı sıfır olduysa, oyun sonlandırılır
            }
        }

        // Oyunun sonlandırılması
        void EndGame()
        {
            timer1.Stop();  // Zamanlayıcıyı durdur
            lbl_over.Show();  // Oyun bitiş mesajını göster
            lbl_over.BringToFront();  // Mesajı ön planda göster
        }

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    // Mermi ve düşman çarpışması
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                // Düşman türüne göre sağlık azaltma
                                int damage = 0;
                                if (i == fastdusman)
                                {
                                    fastEnemyHealth--;
                                    damage = fastEnemyScore;  // Hızlı düşman öldü, puan ekle
                                }
                                else if (i == basicdusman)
                                {
                                    basicEnemyHealth--;
                                    damage = basicEnemyScore;  // Temel düşman öldü, puan ekle
                                }
                                else if (i == bossEnemy)
                                {
                                    bossEnemyHealth--;
                                    damage = bossEnemyScore;  // Boss düşman öldü, puan ekle
                                }
                                else if (i == strongEnemy)
                                {
                                    strongEnemyHealth--;
                                    damage = strongEnemyScore;  // Güçlü düşman öldü, puan ekle
                                }

                                // Düşman öldü, mermiyi kaldır ve yeni konum ver
                                if (i is PictureBox)
                                {
                                    int x = rnd.Next(0, 350);
                                    i.Location = new Point(500, x);  // Düşmanın yeni konumu
                                    this.Controls.Remove(j);  // Mermiyi kaldır
                                    score += damage;  // Puan ekle
                                }
                            }
                        }
                    }

                    // Oyuncunun düşman mermisiyle çarpışması
                    if (j is PictureBox && j.Tag == "dusmanmermi")
                    {
                        if (i == player)
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                DeductPlayerHealth(fastEnemyScore);  // Düşman mermisi oyuncuya çarptı
                                this.Controls.Remove(j);  // Düşman mermisini kaldır
                            }
                        }
                    }

                    // Oyuncunun yıldızla çarpışması
                    if (player.Bounds.IntersectsWith(diamond.Bounds))
                    {
                        playerHealth += 10;  // Yıldız oyuncunun sağlığını artırır
                        lbl_playerHealth.Text = "Health:" + playerHealth.ToString();
                        diamond.Location = new Point(rnd.Next(0, this.ClientSize.Width - diamond.Width), rnd.Next(0, this.ClientSize.Height - diamond.Height));  // Yeni konum
                    }

                    // Oyuncunun taşla çarpışması
                    if (player.Bounds.IntersectsWith(rock.Bounds))
                    {
                        DeductPlayerHealth(10);  // Taşla çarpışma, sağlığı azalt
                        rock.Location = new Point(rnd.Next(0, this.ClientSize.Width - rock.Width), rnd.Next(0, this.ClientSize.Height - rock.Height));  // Yeni konum
                    }
                }
            }

            // Skor ve sağlık bilgilerini güncelle
            lbl_score.Text = "Score: " + score.ToString();
            lbl_playerHealth.Text = "Health: " + playerHealth.ToString();

            // Oyuncunun düşmanlarla çarpışması
            if (player.Bounds.IntersectsWith(fastdusman.Bounds) || player.Bounds.IntersectsWith(basicdusman.Bounds) || player.Bounds.IntersectsWith(strongEnemy.Bounds) || player.Bounds.IntersectsWith(bossEnemy.Bounds))
            {
                // Çarpışan düşman türüne göre sağlık kaybı
                DeductPlayerHealth(fastEnemyScore);  // Hızlı düşmanla çarpışınca
                DeductPlayerHealth(basicEnemyScore);  // Temel düşmanla çarpışınca
                DeductPlayerHealth(bossEnemyScore - 10);  // Boss düşmanla çarpışınca
                DeductPlayerHealth(strongEnemyScore - 10);  // Güçlü düşmanla çarpışınca
            }
        }


        void Star()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "star")
                {
                    x.Left -= 5;
                    if (x.Left < 0)
                    {
                        x.Left = 800;
                    }
                }
            }
        }

        void Diamond()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "diamond")
                {
                    x.Left -= 5;
                    if (x.Left < 0)
                    {
                        x.Left = 800;
                    }
                }
            }
        }

        void Rock()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "engel")
                {
                    x.Left -= 5;
                    if (x.Left < 0)
                    {
                        x.Left = 800;
                    }
                }
            }
        }

        void Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.Image = Properties.Resources.deneme;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top + player.Height / 2 - bullet.Height / 2;
            this.Controls.Add(bullet);
            bullet.BringToFront();

        }

        void Bullet_Movement()
        {
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= 1;
                    if (bulletDirection == "right")
                    {
                        y.Left += 8;
                    }
                    else if (bulletDirection == "left")
                    {
                        y.Left -= 8;
                    }

                    if (y.Top < 0 || y.Left < 0 || y.Left > this.ClientSize.Width)
                    {
                        this.Controls.Remove(y);
                    }
                }

                if (y is PictureBox && y.Tag == "dusmanmermi")
                {
                    y.Top += 10;
                    if (y.Top > this.ClientSize.Height)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
        }

       

        private async void MovingEnemies(PictureBox enemy)
        {
            try
            {
                // Oyuncunun ve düşmanın konumlarını alıyoruz
                int playerY = player.Top;
                int playerX = player.Left;
                int enemyX = enemy.Left;
                int enemyY = enemy.Top;

                // Düşmanın x ve y eksenindeki farkını hesaplıyoruz
                int deltaX = enemyX - playerX;
                int deltaY = enemyY - playerY;

                // Mesafeyi (hipotenüs) hesaplıyoruz
                double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

                // Düşmanı oyuncuya doğru hareket ettiriyoruz
                if (distance > 0) // Bölme işleminde hata almamak için mesafenin 0 olmadığını kontrol ediyoruz
                {
                    enemy.Top -= (int)(enemySpeed * (deltaY / distance));
                    enemy.Left -= (int)(enemySpeed * (deltaX / distance));
                }

                // Düşman ekranın solundan çıkarsa tekrar ekranın sağından görünmesini sağlıyoruz
                if (enemy.Left < 0)
                {
                    enemy.Location = new Point(800, rnd.Next(0, 200));
                }

                await Task.Delay(50); // Düşman hareketini daha akıcı hale getirmek için küçük bir bekleme ekliyoruz
            }
            catch (Exception ex)
            {
                // Olası hataları yakalayıp logluyoruz
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }


        void EnemyBullet(PictureBox enemy)
        {

            fastmermi.Left -= 20;
            if (fastmermi.Left < 0)
            {
                fastmermi = fastdusman;
                fastdusman.Top = fastdusman.Top;
            }
            basicmermi.Left -= 20;
            if (basicmermi.Left < 0)
            {
                basicmermi = basicdusman;
                basicdusman.Top = basicdusman.Top;
            }
            strongmermi.Left -= 20;
            if (strongmermi.Left < 0)
            {
                strongmermi = strongEnemy;
                strongEnemy.Top = strongEnemy.Top;
            }
            bossmermi.Left -= 20;
            if (bossmermi.Left < 0)
            {
                bossmermi = bossEnemy;
                bossEnemy.Top = bossEnemy.Top;
            }

        }

        // Timer'ı Windows Forms timer olarak belirtiyoruz
        System.Windows.Forms.Timer enemyBulletTimer = new System.Windows.Forms.Timer();

        void StartEnemyBulletTimer()
        {
            enemyBulletTimer.Interval = 2000;  // 2 saniyede bir mermi
            enemyBulletTimer.Tick += EnemyBulletTimer_Tick;
            enemyBulletTimer.Start();  // Zamanlayıcıyı başlat
        }

        void EnemyBulletTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Her düşman için mermi oluşturuluyor
                if (fastdusman != null) EnemyBullet(fastdusman);
                if (basicdusman != null) EnemyBullet(basicdusman);
                if (bossEnemy != null) EnemyBullet(bossEnemy);
                if (strongEnemy != null) EnemyBullet(strongEnemy);
            }
            catch (Exception ex)
            {
                // Hata kaydı veya hata yönetimi
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        void EnemyBulletMovement()
        {
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "dusmanmermi")
                {
                    y.Top += 5;  // Mermiyi aşağıya doğru hareket ettiriyoruz

                    // Eğer mermi ekranın altına çıkarsa, onu kaldır
                    if (y.Top > this.ClientSize.Height)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
        }

        //klavye kodu tuslar icin
        void Arrow_key_Movement()
        {
            if (up == true && player.Top > 0) // Yukarı sınır
            {
                player.Top -= 20;
            }
            if (down == true && player.Top + player.Height < this.ClientSize.Height) // Aşağı sınır
            {
                player.Top += 20;
            }
            if (left == true && player.Left > 0) // Sol sınır
            {
                player.Left -= 20;
            }
            if (right == true && player.Left + player.Width < this.ClientSize.Width) // Sağ sınır
            {
                player.Left += 20;
            }
        }

        void CheckLevel()
        {
            if (score >= level * levelThreshold)
            {
                level++;
                enemySpeed += 1;
                enemyBulletInterval = Math.Max(500, 2000 - 200);
                enemyBulletTimer.Interval = 20000;
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Bullet(); // Eğer bu metot hareketle alakalı değilse sorunsuz bırakabilirsiniz.
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // Her fonksiyonu sırayla çalıştırmak için asenkron yapıyı kullanıyoruz
            Star();
            Bullet_Movement();
            await EnemyAsync();  // Asenkron düşman hareket fonksiyonu
            Arrow_key_Movement();
            Game_Result();
            CheckLevel();
            Diamond();
            Rock();
            EnemyBulletMovement();
        }

        // Asenkron düşman hareket fonksiyonu
        private async Task EnemyAsync()
        {
            MovingEnemies(fastdusman);
            MovingEnemies(basicdusman);
            MovingEnemies(bossEnemy);
            MovingEnemies(strongEnemy);

            await Task.Delay(50);  // Asenkron bekleme ekliyoruz
        }
        


        // Form yüklendiğinde mermi zamanlayıcısını başlatıyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            StartEnemyBulletTimer(); // Düşman mermisi zamanlayıcısını başlat
            diamond.Location = new Point(rnd.Next(0, this.ClientSize.Width - diamond.Width), rnd.Next(0, this.ClientSize.Height - diamond.Height)); // Diamond'ı rastgele bir konumda başlat
            rock.Location = new Point(rnd.Next(0, this.ClientSize.Width - rock.Width), rnd.Next(0, this.ClientSize.Height - rock.Height)); // rock rastgele bir konumda başlat
        }

        private void DiamondTimer_Tick(object sender, EventArgs e)
        {
            if (isDiamondVisible)
            {
                // Diamond zaten görünüyorsa, gizle
                diamond.Visible = false;
                isDiamondVisible = false;
            }
            else
            {
                // Diamond'ı göster
                diamond.Visible = true;
                // Diamond'ı rastgele bir konumda başlat
                diamond.Location = new Point(rnd.Next(0, this.ClientSize.Width - diamond.Width), rnd.Next(0, this.ClientSize.Height - diamond.Height));
                isDiamondVisible = true;
            }
        }
        private void RockTimer_Tick(object sender, EventArgs e)
        {
            if (isrockVisible)
            {
                // rock zaten görünüyorsa, gizle
                rock.Visible = false;
                isrockVisible = false;
            }
            else
            {

                rock.Visible = true;
                // rock rastgele bir konumda başlat
                rock.Location = new Point(rnd.Next(0, this.ClientSize.Width - rock.Width), rnd.Next(0, this.ClientSize.Height - rock.Height));
                isrockVisible = true;
            }
        }

    }
}
