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
        private string mDate;
        private double mPrice;
        private List<string> mUserLikes = new List<string>();
        private List<string> mUserDislikes = new List<string>();
        private string mWriteLikes;
        private string mWriteDislikes;


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

        public int Likes
        {
            get
            {
                return mUserLikes.Count();
            }

            
        }

        public int Dislikes
        {
            get
            {
                return mUserDislikes.Count();
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

        public string MWriteLikes
        {
            get
            {
                return mWriteLikes;
            }

            set
            {
                mWriteLikes = value;
            }
        }

        public string MWriteDislikes
        {
            get
            {
                return mWriteDislikes;
            }

            set
            {
                mWriteDislikes = value;
            }
        }

        //creates a new deal
        public Deals(string pProduct, double pPrice, string pDate, List<String> pUserLikes, List<String> pUserDislikes,string pWriteLikes, string pWriteDislikes)
        {
            mProduct = pProduct;
            mPrice = pPrice;
            mDate = pDate;
            mUserLikes = pUserLikes;
            mUserDislikes = pUserDislikes;
            mWriteLikes = pWriteLikes;
            mWriteDislikes = pWriteDislikes;
        }

        //over rides the toString()
        //right now when this is called the like and dislikes are not updated properly
        public override string ToString()
        {
            return mProduct + ": for " + MPrice.ToString("c") + " expires on " + mDate + " Likes:" + Likes + " Dislikes:" + Dislikes;
        }


    }
}
