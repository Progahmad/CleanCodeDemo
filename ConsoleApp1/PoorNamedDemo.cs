using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PoorNamedDemo
    {
   
            /*
             * "Any fool can write code that a computer can understand. 
             * Good programmers write code that humans can understand.”
             *   
             *   ― Martin Fowler
             */

            #region Use Intention-Revealing Names 1

            int x; //exchange rate

            #endregion

            #region Use Intention-Revealing Names 2

            public bool Check(List<string> nam)
            {
                bool fl = true;
                foreach (var n in nam)
                {
                    if (fl)
                    {
                        if (GoesOrNoGoes(n))
                        {
                            fl = false;
                        }
                    }
                }
                return fl;
            }

            private bool GoesOrNoGoes(string emp)
            {
                return string.IsNullOrEmpty(emp);
            }

            #endregion

            #region Avoid Confusion

            public void ExportTheLatestStringFromTheDatabase() { }
            public void ExportTheLatestStringsFromTheDatabase() { }

            #endregion

            #region Make Meaningful Distinctions

            public string[] GetDocumentData()
            {
                return null;
            }

            public string[] GetDocumentInfo()
            {
                return null;
            }

            public string[] FetchDocumentContent()
            {
                return null;
            }

            #endregion

            #region Use Prononouncable Names, Don't Abbreviate

            //Avoid
            int gnofts;
            string deldocn;

            //Do Instead
            int getNumberOfTicketsSold;
            int deletedDocumentName;

            #endregion

            #region Avoid Hungarian Notation

            int i_numberOfEmployees;
            string s_employeeName;

            #endregion

            #region Don't Use Jokes - Don't Be Too Clever

            //Avoid
            public void SendToGraveyard() { } //Name this method Dispose
            public void RememberMyName(string heinsenberg) { } //Name this method SaveCustomerName
            public void MayTheForceBeWithYou() { } //Name this method DisplayLogoutMessage

            #endregion

            #region Avoid Magic Numbers

            public bool ShouldCloseConnection(int responseCode)
            {
                if (responseCode == 211)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public double GetSecondNumberForGoldenRatio(double first)
            {
                return (1.618 * first) - first;
            }

            #endregion

            #region Use Microsoft Naming Convention

            //interface starts with "I"
            interface IRepository { }

            //Omit "I" in class name
            public class Repository : IRepository
            {
                //fields should be private (and can start with underscore), use camelCase
                private int _dataCounter;

                //method names use PascalCase
                //method parameters are in camelCase 
                public void SaveUserDetails(string userDetailKey)
                {

                }

                //Property is PascalCase
                public int NumberOfInvoices { get; set; }
            }

            #endregion

            #region Remember The Boy Scout Rule

            /*
             * "Always leave the code you're editing 
             * a little better than you found it."
             * 
             * - Robert C. Martin (Uncle Bob)
             */

            #endregion
        }
    }


