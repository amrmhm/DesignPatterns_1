using Design_Patterns.Command.Fx;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns.Mediator.EX;

public class RegisterDilogBox 
{
    private TextBox usernameTextBox = new TextBox();
    private TextBox passwordTextBox = new TextBox();
    private CheckBox agreeToTermsCheckBox = new CheckBox();
    private Button signUpButton = new Button();
    public RegisterDilogBox()
    {
        usernameTextBox.addObserver(() => controlChanged());
        passwordTextBox.addObserver(() => controlChanged());
        agreeToTermsCheckBox.addObserver(() => controlChanged());
    }


    private void controlChanged()
    {
        signUpButton.setEnabled(isFormValid());
    }

    private bool isFormValid()
    {
        return !usernameTextBox.getContent().IsWhiteSpace() && !passwordTextBox.getContent().IsWhiteSpace() && agreeToTermsCheckBox.isChecked();
    }

    public void simulateUserInteraction()
    {
        // Initially the button should be disabled
        Console.WriteLine("Initially: " + signUpButton.isEnabled());

        // The user enters their username, the button is still disabled
        usernameTextBox.setContent("username");
        Console.WriteLine("After setting the username: " + signUpButton.isEnabled());

        // The user enters their password, the button is still disabled
        passwordTextBox.setContent("password");
        Console.WriteLine("After setting the password: " + signUpButton.isEnabled());

        // The agrees to the terms, the button becomes enabled
        agreeToTermsCheckBox.setChecked(true);
        Console.WriteLine("After agreeing to terms: " + signUpButton.isEnabled());

        // The user removes the password, the button becomes disabled
        passwordTextBox.setContent("");
        Console.WriteLine("After removing the password: " + signUpButton.isEnabled());

        // The user enters the password again, the button becomes enabled
        passwordTextBox.setContent("password");
        Console.WriteLine("After re-setting the password: " + signUpButton.isEnabled());
    }

}
