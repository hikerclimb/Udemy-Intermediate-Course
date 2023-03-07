
// Program to add, remove and clear ListBox items
using System;
using System.Windows.Forms;

// Form uses a TextBox and Buttons to add,
// remove, and clear ListBox items
public partial class ListBoxTestForm : Form
{
   // default constructor
   public ListBoxTestForm()
   {
      InitializeComponent();
   } // end constructor

   // add new item to ListBox (text from input TextBox)
   // and clear input TextBox
   private void addButton_Click( object sender, EventArgs e )
   {
      displayListBox.Items.Add( inputTextBox.Text );
      inputTextBox.Clear();
   } // end method addButton_Click

   // remove item if one is selected
   private void removeButton_Click( object sender, EventArgs e )
   {
      // check if item is selected, remove if selected
      if ( displayListBox.SelectedIndex != -1 )
         displayListBox.Items.RemoveAt( displayListBox.SelectedIndex );
   } // end method removeButton_Click

   // clear all items in ListBox
   private void clearButton_Click( object sender, EventArgs e )
   {
      displayListBox.Items.Clear();
   } // end method clearButton_Click

   // exit application
   private void exitButton_Click( object sender, EventArgs e )
   {
      Application.Exit();
   } // end method exitButton_Click
} // end class ListBoxTestForm


