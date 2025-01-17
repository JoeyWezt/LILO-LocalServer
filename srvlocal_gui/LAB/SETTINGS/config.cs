﻿namespace srvlocal_gui.LAB.SETTINGS {
    
    
    // Diese Klasse ermöglicht die Behandlung bestimmter Ereignisse der Einstellungsklasse:
    //  Das SettingChanging-Ereignis wird ausgelöst, bevor der Wert einer Einstellung geändert wird.
    //  Das PropertyChanged-Ereignis wird ausgelöst, nachdem der Wert einer Einstellung geändert wurde.
    //  Das SettingsLoaded-Ereignis wird ausgelöst, nachdem die Einstellungswerte geladen wurden.
    //  Das SettingsSaving-Ereignis wird ausgelöst, bevor die Einstellungswerte gespeichert werden.
    public sealed partial class config {
        
        public config() {
            // // Heben Sie die Auskommentierung der unten angezeigten Zeilen auf, um Ereignishandler zum Speichern und Ändern von Einstellungen hinzuzufügen:
            //
            this.SettingChanging += this.SettingChangingEventHandler;
            //
            this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) 
        {
            
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            MessageBox.Show("Settings successfully changed!","Settingsmanager",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
