using System;
using Microsoft.Bot.Builder.FormFlow;

//public enum Pilih Mobil { Convertible = 1, SUV, EV, Trontong, Ledog };
//public enum ColorOptions { Red = 1, White, Blue, Merah, Hijau };

public enum CarOptions { Becak = 1, Bis, Sedan, Ledog, Truk };
public enum ColorOptions { Red = 1, White, Blue };


// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    //[Prompt("Hi! What is your {&}?")]
    //public string Name { get; set; }
    [Prompt("Maaf! Siapa {&} anda?")]
    public string nama { get; set; }

    //[Prompt("Please select your favorite car type {||}")]
    [Prompt("CarOptions mobil {||}")]
    public CarOptions Car { get; set; }
    //public Pilih Mobil { get; set; }

    [Prompt("Please select your favorite {&} {||}")]
    public ColorOptions Color { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
