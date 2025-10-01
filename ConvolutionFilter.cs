using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ConvolutionManip {
    class ConvolutionFilter {

        public static bool Conv3x3(Bitmap b, ConvMatrix m) 
        { 

            // Avoid divide by zero errors 

  

            if (0 == m.Factor) 

                return false; 

     

            // GDI+ still lies to us - the return format is BGR, NOT RGB.  

  

            Bitmap bSrc = (Bitmap)b.Clone(); 

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),  

                                ImageLockMode.ReadWrite,  

                                PixelFormat.Format24bppRgb);  

            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),  

                               ImageLockMode.ReadWrite,  

                               PixelFormat.Format24bppRgb);  

            int stride = bmData.Stride;  

            int stride2 = stride * 2;  

  

            System.IntPtr Scan0 = bmData.Scan0;  

            System.IntPtr SrcScan0 = bmSrc.Scan0;  

  

            unsafe {  

                byte * p = (byte *)(void *)Scan0;  

                byte * pSrc = (byte *)(void *)SrcScan0;  

                int nOffset = stride - b.Width*3;  

                int nWidth = b.Width - 2;  

                int nHeight = b.Height - 2;  

         

                int nPixel;  

         

                for(int y=0;y < nHeight;++y)  

                {  

                    for(int x=0; x < nWidth; ++x )  

                    { 

                        nPixel = ( ( ( (pSrc[2] * m.TopLeft) +  

                            (pSrc[5] * m.TopMid) +  

                            (pSrc[8] * m.TopRight) +  

                            (pSrc[2 + stride] * m.MidLeft) +  

                            (pSrc[5 + stride] * m.Pixel) +  

                            (pSrc[8 + stride] * m.MidRight) +  

                            (pSrc[2 + stride2] * m.BottomLeft) +  

                            (pSrc[5 + stride2] * m.BottomMid) +  

                            (pSrc[8 + stride2] * m.BottomRight))  

                            / m.Factor) + m.Offset);  

                     

                        if (nPixel < 0) nPixel = 0;  

                        if (nPixel > 255) nPixel = 255;  

                        p[5 + stride]= (byte)nPixel;  

                 

                        nPixel = ( ( ( (pSrc[1] * m.TopLeft) +  

                            (pSrc[4] * m.TopMid) +  

                            (pSrc[7] * m.TopRight) +  

                            (pSrc[1 + stride] * m.MidLeft) +  

                            (pSrc[4 + stride] * m.Pixel) +  

                            (pSrc[7 + stride] * m.MidRight) +  

                            (pSrc[1 + stride2] * m.BottomLeft) +  

                            (pSrc[4 + stride2] * m.BottomMid) +  

                            (pSrc[7 + stride2] * m.BottomRight))  

                            / m.Factor) + m.Offset);  

                     

                        if (nPixel < 0) nPixel = 0;  

                        if (nPixel > 255) nPixel = 255;  

                        p[4 + stride] = (byte)nPixel;  

                 

                        nPixel = ( ( ( (pSrc[0] * m.TopLeft) +  

                                       (pSrc[3] * m.TopMid) +  

                                       (pSrc[6] * m.TopRight) +  

                                       (pSrc[0 + stride] * m.MidLeft) +  

                                       (pSrc[3 + stride] * m.Pixel) +  

                                       (pSrc[6 + stride] * m.MidRight) +  

                                       (pSrc[0 + stride2] * m.BottomLeft) +  

                                       (pSrc[3 + stride2] * m.BottomMid) +  

                                       (pSrc[6 + stride2] * m.BottomRight))  

                            / m.Factor) + m.Offset);  

                     

                        if (nPixel < 0) nPixel = 0;  

                        if (nPixel > 255) nPixel = 255;  

                        p[3 + stride] = (byte)nPixel;  

                 

                        p += 3;  

                        pSrc += 3;  

                    }  

             

                    p += nOffset;  

                    pSrc += nOffset;  

                }  

            }  

     

            b.UnlockBits(bmData);  

            bSrc.UnlockBits(bmSrc);
            
            bSrc.Dispose();

            return true;  

        }  

        public static bool Sharpen(Bitmap b, int nWeight)
        {
            if(nWeight <= 0) return true;

            nWeight--;

            Sharpen(b, nWeight);

            ConvMatrix m = new ConvMatrix(); 

            m.SetAll(0);

            m.TopMid = -2;
            m.BottomMid = -2;
            m.MidLeft = -2;
            m.MidRight = -2;

            m.Pixel = 11; 

            m.Factor = 3;

            m.Offset = 0;


            return Conv3x3(b, m); 


        }

        public static bool GaussianBlur(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();

            m.SetAll(1);
            m.TopMid = 2;
            m.BottomMid = 2;
            m.MidLeft = 2;
            m.MidRight = 2;
            m.Pixel = 4;
            m.Factor = 16;
            return Conv3x3(b, m);
        }
        public static bool EmbossLaplascian(Bitmap b, int nWeight) { 
            
            ConvMatrix m = new ConvMatrix();
	        m.SetAll(-1);
	        m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 0;
	        m.Pixel = 4;
	        m.Offset = 127;
            return Conv3x3(b,m);    
        }
        public static bool EmbossLossy(Bitmap b, int nWeight) { 
            
            ConvMatrix m = new ConvMatrix();

            m.SetAll(-2);
            m.TopLeft = 1;
            m.TopRight= 1;
            m.BottomMid = 1;
            m.Pixel = 4;
            m.Factor = 1;
            m.Offset= 127;
            return Conv3x3(b,m);    
        }
        public static bool MeanRemoval(Bitmap b, int nWeight) { 
            
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 9;
            m.Factor = 1;
            
            return Conv3x3(b,m);    
        }
        public static bool HorizontalEmboss(Bitmap b, int nWeight) {
            
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = -1;
            m.MidRight = -1;
            m.Pixel = 2;
            m.Factor = 1;
            m.Offset = 127;
            
            return Conv3x3(b,m);    
        }

        public static bool CustomMatrix(Bitmap b, ConvMatrix m) { 
            return Conv3x3(b,m);
        }


    }
}
