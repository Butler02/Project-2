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
        private List<string> mUserLikes = new List<string>();
        private List<string> mUserDislikes = new List<string>();


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
                return mUserLikes;
            }

            set
            {
                mUserLikes = value;
            }
        }

        public List<string> UserDislikes
        {
            get
            {
                return mUserDislikes;
            }

            set
            {
                mUserDislikes = value;
            }
        }

        //creates a new deal
        public Deals(string pProduct, double pPrice, string pDate, int pLikes, int pDislikes, List<String> pUserLikes, List<String> pUserDislikes)
        {
            MProduct = pProduct;
            MPrice = pPrice;
            MDate = pDate;
            MLikes = pLikes;
            MDislikes = pDislikes;
            mUserLikes = pUserLikes;
            mUserDislikes = pUserDislikes;
        }

        //over rides the toString()
        public override string ToString()
        {
            return mProduct + ": for " + MPrice.ToString("c") + " expires on " + mDate + " Likes:" + mLikes + " Dislikes:" + mDislikes;
        }


    }
}
