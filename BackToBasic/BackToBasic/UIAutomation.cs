using System;
using System.Windows;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

namespace BackToBasic
{
    public class UIAutomation
    {



        public static void Main()
        {

            string returnString = string.Empty;
            DateTime date = DateTime.ParseExact("01312016", "MMddyyyy", CultureInfo.InvariantCulture);
            returnString = date.ToString("MM/dd/yyyy") + " - " + date.AddMonths(1).ToString("MM/dd/yyyy");
            


            BaseClass BaseClass = new BaseClass();
            BaseClass.num1();
            BaseClass.num2();
            BaseClass.num0();
            BaseClass.num1();
            //BaseClass.num7();
            BaseClass.minus();



            BaseClass.num1();
            BaseClass.num9();
            BaseClass.num9();
            BaseClass.num1();
            BaseClass.equal();
            //BaseClass.viewResult();
            //BaseClass.getWinWordTextAndSet();
            BaseClass.WriteNotepad();
        }

        public class BaseClass
        {
            
            AutomationElement rootElement = AutomationElement.RootElement;

            public void WriteNotepad()
            {
                try
                {


                    Condition condition = new PropertyCondition(AutomationElement.ClassNameProperty, "Notepad");
                    AutomationElement appElement = rootElement.FindFirst(TreeScope.Children, condition);

                    WindowPattern window = appElement.GetCurrentPattern(WindowPattern.Pattern) as WindowPattern;
                    window.SetWindowVisualState(WindowVisualState.Normal);

                    AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "15"));



                    //ValuePattern ValPattern = btnOne.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                    btnOne.SetFocus();
                    SendKeys.SendWait("Vincent Lee Flores");
                    //InsertText(btnOne, "enteng");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error in: {0}", Ex.ToString().Trim());
                }
            }


            private void InsertText(AutomationElement targetControl,
                                    string value)
            {
                // Validate arguments / initial setup
                if (value == null)
                    throw new ArgumentNullException(
                        "String parameter must not be null.");

                if (targetControl == null)
                    throw new ArgumentNullException(
                        "AutomationElement parameter must not be null");

                // A series of basic checks prior to attempting an insertion.
                //
                // Check #1: Is control enabled?
                // An alternative to testing for static or read-only controls 
                // is to filter using 
                // PropertyCondition(AutomationElement.IsEnabledProperty, true) 
                // and exclude all read-only text controls from the collection.
                if (!targetControl.Current.IsEnabled)
                {
                    throw new InvalidOperationException(
                        "The control is not enabled.\n\n");
                }

                // Check #2: Are there styles that prohibit us 
                //           from sending text to this control?
                if (!targetControl.Current.IsKeyboardFocusable)
                {
                    throw new InvalidOperationException(
                        "The control is not focusable.\n\n");
                }

                // Once you have an instance of an AutomationElement,  
                // check if it supports the ValuePattern pattern.
                object valuePattern = null;

                if (!targetControl.TryGetCurrentPattern(
                    ValuePattern.Pattern, out valuePattern))
                {
                    // Elements that support TextPattern 
                    // do not support ValuePattern and TextPattern
                    // does not support setting the text of 
                    // multi-line edit or document controls.
                    // For this reason, text input must be simulated.
                }
                // Control supports the ValuePattern pattern so we can 
                // use the SetValue method to insert content.
                else
                {
                    if (((ValuePattern)valuePattern).Current.IsReadOnly)
                    {
                        throw new InvalidOperationException(
                            "The control is read-only.");
                    }
                    else
                    {
                        ((ValuePattern)valuePattern).SetValue(value);
                    }
                }
            }



            public void num1()
            {
                try
                {


                    Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");
                    AutomationElement appElement = rootElement.FindFirst(TreeScope.Children, condition);

                    WindowPattern window = appElement.GetCurrentPattern(WindowPattern.Pattern) as WindowPattern;
                    window.SetWindowVisualState(WindowVisualState.Normal);

                    //Condition panel = new PropertyCondition(AutomationElement.ClassNameProperty, "Windows.UI.Core.CoreWindow");
                    //AutomationElement appPanel = appElement.FindFirst(TreeScope.Children, panel);

                    //Condition btnOneCondition = new PropertyCondition(AutomationElement.AutomationIdProperty, "num1Button");
                    //AutomationElement btnOne = appPanel.FindFirst(TreeScope.Descendants, btnOneCondition);


                    //Condition btnOneCondition = new PropertyCondition(AutomationElement.AutomationIdProperty, "num1Button");
                    //PropertyCondition conditionCanMaximize = new PropertyCondition(WindowPattern.WindowVisualStateProperty, WindowVisualState.Normal);
                    


                    AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "num1Button"));

                    
                    
                    InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                    btnOnePattern.Invoke();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error in: {0}", Ex.ToString().Trim());
                }
            }

            public void num9()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "num9Button"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }

            public void num2()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "num2Button"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }
            public void num0()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "num0Button"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }
            public void num7()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "num7Button"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }


            public void minus()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "minusButton"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }
            public void equal()
            {
                AutomationElement btnOne = rootElement.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.AutomationIdProperty, "equalButton"));

                InvokePattern btnOnePattern = btnOne.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnOnePattern.Invoke();
            }

            public void viewResult()
            {
                //CalculatorResults
                AutomationElement result = rootElement.FindFirst(TreeScope.Descendants,
                    new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults"));

                object patternObj;
                string value = string.Empty;
                if (result.TryGetCurrentPattern(ValuePattern.Pattern, out patternObj))
                {
                    var valPattern = (ValuePattern)patternObj;
                    value = valPattern.Current.Value;
                }
                else if (result.TryGetCurrentPattern(TextPattern.Pattern, out patternObj))
                {
                    var textPattern = (TextPattern)patternObj;
                    value = textPattern.DocumentRange.GetText(-1).TrimEnd('\r');
                }
                else
                {
                    value = result.Current.Name;
                }

                MessageBox.Show(value);

            }

            public void getWinWordTextAndSet()
            {
                


                    AutomationElement result = rootElement.FindFirst(TreeScope.Descendants,
                    new PropertyCondition(AutomationElement.AutomationIdProperty, "UIA_AutomationId_Word_Content_Page_1"));

                object patternObj;
                string value = string.Empty;
                if (result.TryGetCurrentPattern(ValuePattern.Pattern, out patternObj))
                {
                    var valPattern = (ValuePattern)patternObj;
                    value = valPattern.Current.Value;
                }
                else if (result.TryGetCurrentPattern(TextPattern.Pattern, out patternObj))
                {
                    var textPattern = (TextPattern)patternObj;
                    value = textPattern.DocumentRange.GetText(-1).TrimEnd('\r');
                }
                else
                {
                    value = result.Current.Name;
                }

                MessageBox.Show(value);

                Point p = result.GetClickablePoint();
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)p.X, (int)p.Y);
                LeftClick();
                RightClick();


            }

            [DllImport("user32.dll")]
            static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


            private const int MOUSEEVENTF_MOVE = 0x0001;
            private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            private const int MOUSEEVENTF_LEFTUP = 0x0004;
            private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            private const int MOUSEEVENTF_RIGHTUP = 0x0010;
            private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
            private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
            public static void LeftClick()
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }

            public static void RightClick()
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }

        }
          
    }
}
