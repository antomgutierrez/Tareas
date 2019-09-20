using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact dueño = new Contact("");
            dueño.Phone = "+598095384662";
            // Crear el contacto dueño

            Phonebook agenda = new Phonebook(dueño);
            // Crear la lista de contactos

            var contacto1 = new Contact("contacto1");
            var contacto2 = new Contact("contacto2");
            var contacto3 = new Contact("contacto3");
            var contacto4 = new Contact("contacto4");

            agenda.add(contacto1);
            agenda.add(contacto2);
            agenda.add(contacto3);
            agenda.add(contacto4);

            // Agregar contactos a la lista

            var to1 = agenda.SearchNumber("contacto1");
            var to2 = agenda.SearchNumber("contacto2");
            
            var text1 = "Hola";
            var text2 = "Hola";            
            
            Message mensaje1 = new Whatsapp("+14155238886", dueño.Phone);
            mensaje1.Text = text1;
            Message mensaje2 = new Whatsapp("+14155238886", dueño.Phone);
            mensaje2.Text = text1;
            mensaje1.Send(mensaje1);
            mensaje2.Send(mensaje2);
            // Enviar un WhatsApp a algunos contactos

            Message mensaje3 = new Twitter("809690515", "");
            mensaje3.Text = text2;
            Message mensaje4 = new Twitter("809690515", "");
            mensaje4.Text = text2;
            mensaje3.Send(mensaje3);
            mensaje4.Send(mensaje4);
            // Enviar un MD en Twitter a algunos contactos
            
        
        }
    }
}
