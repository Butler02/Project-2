using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Shopping
{
    class Deals
    {
        private string mProduct;
        private int mLikes;
        private int mDislikes;
        private string mDate;
        private double mPrice;
        private List<string> userLikes=new List<string>();
        private List<string> userDislikes = new List<string>();


        public string MProduct
        {
            get
            {
                return mProduct;
            }

            set
            {
                mProduct = value;
            }
        }

        public int MLikes
        {
            get
            {
                return mLikes;
            }

            set
            {
                mLikes = value;
            }
        }

        public int MDislikes
        {
            get
            {
                return mDislikes;
            }

            set
            {
                mDislikes = value;
            }
        }

        public string MDate
        {
            get
            {
                return mDate;
            }

            set
            {
                mDate = value;
            }
        }

        public double MPrice
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        public List<string> UserLikes
        {
            get
            {
                return userLikes;
            }

            set
            {
                userLikes = value;
            }
        }

        public List<string> UserDislikes
        {
            get
            {
                return userDislikes;
            }

            set
            {
                userDislikes = value;
            }
        }

        //creates a new deal
        public Deals(string pProduct, double pPrice, string pDate, int pLikes, int pDislikes)
        {
            MProduct = pProduct;
            MPrice = pPrice;
            MDate = pDate;
            MLikes = pLikes;
            MDislikes = pDislikes;
        }

        //over rides the toString()
        public override string ToString()
        {
            return mProduct+": for "+MPrice+" expires on "+mDate+" Likes:"+mLikes+" Dislikes:"+mDislikes;
        }


    }
}
