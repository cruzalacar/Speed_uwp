using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_UWP
{
    class InvalidCardNumberException : Exception
    {

        private byte _cardNo;
        private byte _cardMinNo;
        private byte _cardMaxNo;

        /// <summary>
        /// Creates the InvalidCardNumberException constructor. This is specific constructor acts as the default
        /// </summary>
        public InvalidCardNumberException() : base()
        {
        }

        /// <summary>
        /// One of the two overloads of the constructor for the InvalidCardNumberException. 
        /// This specific one takes in a string as a parameter
        /// </summary>
        /// <param name="message">string type</param>
        public InvalidCardNumberException(string message) : base(message)
        {
        }

        /// <summary>
        /// This is the second overload of the constructor for the user defined exception that
        /// takes in three byte type parameters.
        /// </summary>
        /// <param name="cardNo">byte type</param>
        /// <param name="cardMinNo">byte type</param>
        /// <param name="cardMaxNo">byte type</param>
        public InvalidCardNumberException(byte cardNo, byte cardMinNo, byte cardMaxNo)
        {
            _cardNo = cardNo;
            _cardMinNo = cardMinNo;
            _cardMaxNo = cardMaxNo;
        }

        /// <summary>
        /// Byte type property for the CardNo 
        /// </summary>
        public byte CardNo { get { return _cardNo; } set { _cardNo = value; } }

        //Define AUTOMATIC PROPERTY for CardMinNo
        public byte CardMinNo { get { return _cardMinNo; } set { _cardMinNo = value; } }

        //Define AUTOMATIC PROPERTY for CardMaxNo
        public byte CardMaxNo { get { return _cardMaxNo; } set { _cardMaxNo = value; } }

        public override string Message
        {
            get
            {
                //if a card number was provided create a custom message
                if (CardNo > 0)
                {
                    return String.Format($"{CardNo} is not a valid card number. Please choose a number between {CardMinNo} and {CardMaxNo}");
                }
                else
                {
                    return base.Message;
                }
            }
        }
    }
}
