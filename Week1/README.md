
# C# Code Explanation

# 1. Reading Text Input ( String )


String name = txtname.Text;


Reads the input text from the `txtname` TextBox and assigns it to the string variable `name`.

Used to store text-based user input, such as a person's name, for later processing.


# 2. Converting String Input to Integer ( int.Parse )

int studentID = int.Parse(txtstudentid.Text);


Converts the text entered in `txtstudentid` into an integer using `int.Parse()` and stores it in the `studentID` variable.

Since input fields return data as strings, parsing converts numerical text into an actual integer format required for numerical logic or calculations.


# 3. Clearing Input Fields ( Clear() )

txtname.Clear();
txtstudentid.Clear();
txtdepartment.Clear();
txtsememster.Clear();

Calls the `Clear()` method on each specified TextBox (`txtname`, `txtstudentid`, `txtdepartment`, and `txtsememster`) to remove all entered text.


Typically used in a "Reset" or "Clear" button event to reset the form fields so the user can enter new data.


# 4. Closing the Current Form ( this.Close() )

this.Close();

Closes the active window or form where this code is executed.

Commonly executed when a user clicks an "Exit" or "Close" button to dismiss the interface.


# 5. Clearing Label Output ( Label Output )


lbloutput.Text = "";

Sets the `Text` property of the `lbloutput` Label control to an empty string (`""`).


Clears displayed output messages or results from the screen, resetting the label display.