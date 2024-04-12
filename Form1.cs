using GMap.NET;
using GMap.NET.Internals;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
using System.Windows.Forms.Design;

namespace HMapLoader_GMap
{
    public partial class Form1 : Form
    {
        private static readonly string[] user_agent_list = {
        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.27 (KHTML, like Gecko) Chrome/12.0.712.0 Safari/534.27",
        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.24 Safari/535.1",
        "Mozilla/5.0 (Windows NT 6.0) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.120 Safari/535.2",
        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.7 (KHTML, like Gecko) Chrome/16.0.912.36 Safari/535.7",
        "Mozilla/5.0 (Windows; U; Windows NT 6.0 x64; en-US; rv:1.9pre) Gecko/2008072421 Minefield/3.0.2pre",
        "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.10) Gecko/2009042316 Firefox/3.0.10",
        "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.0.11) Gecko/2009060215 Firefox/3.0.11 (.NET CLR 3.5.30729)",
        "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 GTB5",
        "Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)",
        "Mozilla/5.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
        "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0.1) Gecko/20100101 Firefox/4.0.1",
        "Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0",
        "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110622 Firefox/6.0a2",
        "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:7.0.1) Gecko/20100101 Firefox/7.0.1",
        "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b4pre) Gecko/20100815 Minefield/4.0b4pre",
        "Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 5.0 )",
        "Mozilla/4.0 (compatible; MSIE 5.5; Windows 98; Win 9x 4.90)",
        "Mozilla/5.0 (Windows; U; Windows XP) Gecko MultiZilla/1.6.1.0a",
        "Mozilla/2.02E (Win95; U)",
        "Mozilla/3.01Gold (Win95; I)",
        "Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.4) Gecko Netscape/7.1 (ax)",
        "HTC_Dream Mozilla/5.0 (Linux; U; Android 1.5; en-ca; Build/CUPCAKE) AppleWebKit/528.5  (KHTML, like Gecko) Version/3.1.2 Mobile Safari/525.20.1",
        "Mozilla/5.0 (hp-tablet; Linux; hpwOS/3.0.2; U; de-DE) AppleWebKit/534.6 (KHTML, like Gecko) wOSBrowser/234.40.1 Safari/534.6 TouchPad/1.0",
        "Mozilla/5.0 (Linux; U; Android 1.5; en-us; sdk Build/CUPCAKE) AppleWebkit/528.5  (KHTML, like Gecko) Version/3.1.2 Mobile Safari/525.20.1",
        "Mozilla/5.0 (Linux; U; Android 2.1; en-us; Nexus One Build/ERD62) AppleWebKit/530.17 (KHTML, like Gecko) Version/4.0 Mobile Safari/530.17",
        "Mozilla/5.0 (Linux; U; Android 2.2; en-us; Nexus One Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1",
        "Mozilla/5.0 (Linux; U; Android 1.5; en-us; htc_bahamas Build/CRB17) AppleWebKit/528.5  (KHTML, like Gecko) Version/3.1.2 Mobile Safari/525.20.1",
        "Mozilla/5.0 (Linux; U; Android 2.1-update1; de-de; HTC Desire 1.19.161.5 Build/ERE27) AppleWebKit/530.17 (KHTML, like Gecko) Version/4.0 Mobile Safari/530.17",
        "Mozilla/5.0 (Linux; U; Android 2.2; en-us; Sprint APA9292KT Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1",
        };

        GMapControl map;

        GMapOverlay overlay;

        List<PointLatLng> points;

        bool isDraw = false;

        GPoint minTile = GPoint.Empty;
        GPoint maxTile = GPoint.Empty;

        public Form1()
        {
            InitializeComponent();

            LoadGMap();
        }

        private void LoadGMap()
        {

            overlay = new GMapOverlay();
            points = new List<PointLatLng>();

            map = new GMapControl
            {
                Location = new Point(pn.Location.X, pn.Location.Y),
                Size = new Size(pn.Size.Width, pn.Size.Height),
                Padding = pn.Padding,
                Anchor = pn.Anchor,
                Visible = true,
            };
            pn.Controls.Add(map);

            if (!GMapControl.IsDesignerHosted)
            {
                GMapProvider.Language = LanguageType.ChineseSimplified;
                map.DragButton = MouseButtons.Left;
                map.EmptyMapBackground = System.Drawing.Color.FromArgb(240, 240, 240);
                map.EmptyTileBorders = new Pen(System.Drawing.Color.FromArgb(0, 100, 240), 3);
                map.EmptyTileColor = System.Drawing.Color.FromArgb(240, 240, 240);
                map.EmptyTileText = null;
                map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(240, 240, 240);
                map.ShowCenter = false;
                map.MaxZoom = 20;
                map.MinZoom = 0;
                map.Zoom = 8;
                map.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                map.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
                map.HelperLineOption = HelperLineOptions.ShowAlways;//辅助光标十字
                map.Manager.Mode = AccessMode.ServerOnly;//底图加载模式
                map.Position = new PointLatLng(23.32, 113.55);
                map.MapProvider = GMapProviders.AMapSatellite;//高德地图
                map.Overlays.Add(overlay);
                
                map.OnMapClick += Map_OnMapClick;
                map.MouseMove += Map_MouseMove;
                map.OnMapZoomChanged += Map_OnMapZoomChanged;

                map.DisableFocusOnMouseEnter = true;

                tbZoom.Text = map.Zoom.ToString();
                nudZoom.Value = (int)map.Zoom;
                cmbMapType.SelectedIndex = 1;
                cmbMapType.SelectedIndexChanged += cmbMapType_SelectedIndexChanged;
            }
        }

        private void Map_OnMapZoomChanged()
        {
            tbZoom.Text = map.Zoom.ToString();
            nudZoom.Value = (decimal)map.Zoom;
        }

        private void Map_MouseMove(object? sender, MouseEventArgs e)
        {
            var p = map.FromLocalToLatLng(e.X, e.Y);

            tbLng.Text = p.Lng.ToString();
            tbLat.Text = p.Lat.ToString();

            if (!isDraw || points.Count != 1) { return; }

            overlay.Clear();
            GMapPolygon extent = CreateExtent(points[0], p);
            overlay.Polygons.Add(extent);
        }

        private void Map_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (!isDraw) { return; }

            if (points.Count == 0)
            {
                overlay.Markers.Add(new GMarkerGoogle(pointClick, GMarkerGoogleType.blue));

                points.Add(pointClick);
            }
            else if (points.Count == 1)
            {
                overlay.Clear();

                GMapPolygon extent = CreateExtent(points[0], pointClick);

                overlay.Polygons.Add(extent);

                isDraw = false;

                nudCrawlExtentU.Value = (decimal)extent.Points[2].Lat;
                nudCrawlExtentD.Value = (decimal)extent.Points[0].Lat;
                nudCrawlExtentL.Value = (decimal)extent.Points[0].Lng;
                nudCrawlExtentR.Value = (decimal)extent.Points[2].Lng;

                UpdateTileExtent();
            }
        }

        private GMapPolygon CreateExtent(PointLatLng p1, PointLatLng p2)
        {
            List<PointLatLng> p = new List<PointLatLng>();

            double minLat = Math.Min(p1.Lat, p2.Lat);
            double minLng = Math.Min(p1.Lng, p2.Lng);
            double maxLat = Math.Max(p1.Lat, p2.Lat);
            double maxLng = Math.Max(p1.Lng, p2.Lng);

            p.Add(new PointLatLng(minLat, minLng));
            p.Add(new PointLatLng(maxLat, minLng));
            p.Add(new PointLatLng(maxLat, maxLng));
            p.Add(new PointLatLng(minLat, maxLng));

            return new GMapPolygon(p, p.Count.ToString());
        }

        private void UpdateTileExtent()
        {
            if (nudZoom.Value > 20 || nudZoom.Value < 1) { return; }

            if (overlay.Polygons.Count != 1) { return; }

            var minPixel = map.MapProvider.Projection.FromLatLngToPixel((double)nudCrawlExtentU.Value, (double)nudCrawlExtentL.Value, (int)nudZoom.Value);
            minTile = map.MapProvider.Projection.FromPixelToTileXY(minPixel);
            var maxPixel = map.MapProvider.Projection.FromLatLngToPixel((double)nudCrawlExtentD.Value, (double)nudCrawlExtentR.Value, (int)nudZoom.Value);
            maxTile = map.MapProvider.Projection.FromPixelToTileXY(maxPixel);

            nudCrawlRowMin.Value = minTile.Y;
            nudCrawlRowMax.Value = maxTile.Y;
            nudCrawlColMin.Value = minTile.X;
            nudCrawlColMax.Value = maxTile.X;

            tbTileCount_Update(null, null);
        }

        private void nudZoom_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileExtent();
        }


        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            try
            {
                lbCrawl.Text = "爬取中..";

                int zoom = (int)nudZoom.Value;
                int minCol = (int)nudCrawlColMin.Value;
                int maxCol = (int)nudCrawlColMax.Value;
                int minRow = (int)nudCrawlRowMin.Value;
                int maxRow = (int)nudCrawlRowMax.Value;


                using (HttpClient httpClient = new HttpClient())
                {
                    // 设置User-Agent为常见的浏览器标识，以避免被检测为非正常请求  
                    var random = new Random();
                    httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(user_agent_list[random.Next(0, 20)]);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("image/*")); // 指定接受的媒体类型为图片   

                    string zoomPath = $@"{tbCrawlOutput.Text}\{zoom}";
                    if (!Directory.Exists(zoomPath)) { Directory.CreateDirectory(zoomPath); }

                    string crawlUrl = "";
                    switch (cmbMapType.Text)
                    {
                        case "矢量": crawlUrl = "https://webst01.is.autonavi.com/appmaptile?style=7&"; break;
                        case "影像": crawlUrl = "https://webst01.is.autonavi.com/appmaptile?style=6&"; break;
                        case "路网": crawlUrl = "https://webst01.is.autonavi.com/appmaptile?style=8&ltype=3&"; break;
                    }

                    for (int row = minRow; row <= maxRow; row++)
                    {
                        string rowPath = $@"{zoomPath}\{row}";
                        if (!Directory.Exists(rowPath)) { Directory.CreateDirectory(rowPath); }

                        for (int col = minCol; col <= maxCol; col++)
                        {
                            string url = crawlUrl + $"&x={col}&y={row}&z={zoom}";
                            // 发送GET请求获取图片内容  
                            HttpResponseMessage response = await httpClient.GetAsync(url);
                            response.EnsureSuccessStatusCode(); // 确保请求成功  
                            byte[] imageBytes = await response.Content.ReadAsByteArrayAsync(); // 读取图片内容为字节数组   
                                                                                               // 将图片内容写入本地文件  
                            File.WriteAllBytes(@$"{rowPath}\{col}.png", imageBytes);

                            response.Dispose();
                        }
                    }
                }

                lbCrawl.Text = "爬取成功";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            try
            {
                lbCombine.Text = "拼接中";
                Tile tilesBounds;

                tilesBounds = new Tile
                {
                    zoomLevel = (int)nudZoom.Value,
                    minCol = (int)nudCrawlColMin.Value,
                    maxCol = (int)nudCrawlColMax.Value,
                    minRow = (int)nudCrawlRowMin.Value,
                    maxRow = (int)nudCrawlRowMax.Value,
                };

                int rowLength = (tilesBounds.maxRow - tilesBounds.minRow + 1) * 256;
                int colLength = (tilesBounds.maxCol - tilesBounds.minCol + 1) * 256;

                Bitmap b = new Bitmap(colLength, rowLength);

                using (Graphics g = Graphics.FromImage(b))
                {
                    Image img;

                    for (int row = tilesBounds.minRow; row <= tilesBounds.maxRow; row++)
                    {
                        for (int col = tilesBounds.minCol; col <= tilesBounds.maxCol; col++)
                        {

                            string sourceFileName = @$"{tbCombineInput.Text}\{tilesBounds.zoomLevel}\{row}\{col}.png";
                            if (!File.Exists(sourceFileName)) { continue; }

                            img = Image.FromFile(sourceFileName);

                            g.DrawImage(img, (col - tilesBounds.minCol) * 256, (row - tilesBounds.minRow) * 256, 256, 256);
                        }
                    }

                    b.Save(tbCombineOutput.Text);
                }
                b.Dispose();

                lbCombine.Text = "拼接成功";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCombineOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) { return; }

            tbCombineInput.Text = dialog.SelectedPath;
        }

        private void btnCrawlOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK) { return; }

            tbCrawlOutput.Text = dialog.SelectedPath;
            tbCombineInput.Text = dialog.SelectedPath;
            tbCombineOutput.Text = $@"{dialog.SelectedPath}\{nudZoom.Value}.png";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            overlay.Clear();
            points.Clear();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            overlay.Clear();
            points.Clear();
            isDraw = true;
        }

        private void chkGrid_CheckedChanged(object sender, EventArgs e)
        {
            map.ShowTileGridLines = chkGrid.Checked;
        }

        private void tbTileCount_Update(object sender, EventArgs e)
        {
            tbTileCount.Text = ((nudCrawlColMax.Value - nudCrawlColMin.Value + 1) * (nudCrawlRowMax.Value - nudCrawlRowMin.Value + 1)).ToString();
        }

        private void nudCrawlExtent_ValueChanged(object sender, EventArgs e)
        {
            decimal colZ = (decimal)Math.Pow(2, (double)nudZoom.Value);
            double rowZ = Math.Pow(2, (double)nudZoom.Value - 1);
            int colMin = (int)Math.Truncate((Math.Min(nudCrawlExtentL.Value, nudCrawlExtentR.Value) + 180) / 360 * colZ);
            int RowMin = (int)Math.Truncate((1 - Math.Asinh(Math.Tan((double)Math.Max(nudCrawlExtentU.Value, nudCrawlExtentD.Value) * Math.PI / 180)) / Math.PI) * rowZ);
            int colMax = (int)Math.Truncate((Math.Max(nudCrawlExtentL.Value, nudCrawlExtentR.Value) + 180) / 360 * colZ);
            int RowMax = (int)Math.Truncate((1 - Math.Asinh(Math.Tan((double)Math.Min(nudCrawlExtentU.Value, nudCrawlExtentD.Value) * Math.PI / 180)) / Math.PI) * rowZ);

            nudCrawlColMin.Value = Math.Max(0, colMin);
            nudCrawlColMax.Value = Math.Max(0, colMax);
            nudCrawlRowMin.Value = Math.Max(0, RowMin);
            nudCrawlRowMax.Value = Math.Max(0, RowMax);
        }

        private void cmbMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMapType.Text)
            {
                case "矢量": map.MapProvider = GMapProviders.AMapVector; break;
                case "影像": map.MapProvider = GMapProviders.AMapSatellite; break;
                case "路网": map.MapProvider = GMapProviders.AMapRoad; break;
            }

            map.ReloadMap();
        }
    }

    public class Tile
    {
        public int minCol;
        public int maxCol;
        public int minRow;
        public int maxRow;
        public int zoomLevel;
    }
}
