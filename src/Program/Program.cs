using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact dueño = new Contact("");
            // Crear el contacto dueño

            Phonebook agenda = new Phonebook(dueño);
            // Crear la lista de contactos

            string[] nombres = {"contacto1","contacto2", "contacto3", "contacto4"};
            var lista_contactos = agenda.Search(nombres);
            // Agregar contactos a la lista

            var to1 = agenda.SearchNumber("contacto1");
            var to2 = agenda.SearchNumber("contacto2");
            
            var text1 = "";
            var text2 = "";
            
            
            Whatsapp mensaje2 = Message.CreateMessage(dueño.Name, "", text1);
            mensaje1.Send(mensaje1);
            mensaje2.Send(mensaje2);
            // Enviar un WhatsApp a algunos contactos

            Twitter mensaje3 = new Message(dueño.Name, "");
            Twitter mensaje4 = new Message(dueño.Name, "");
            mensaje3.Send(mensaje3);
            mensaje4.Send(mensaje4);
            // Enviar un MD en Twitter a algunos contactos
            
        
        }
    }
}
