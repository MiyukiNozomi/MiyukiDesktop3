"use strict";
class StartMenu {
    constructor() {
        this.Showing = false;
        this.startMenu = null;
        this.desktopPane = null;
    }
    onStartClick() {
        if (this.startMenu == null || this.desktopPane == null) {
            this.startMenu = document.getElementById("@SystemUI/Desktop/StartMenu");
            this.desktopPane = document.getElementById("@SystemUI/Desktop");
        }
        if (this.startMenu == null || this.desktopPane == null) {
            //TODO give a BSOD
            alert("Debug Error! missing start menu or desktopPane");
            return;
        }
        if (this.Showing) {
            this.startMenu.style.display = "none";
            this.desktopPane.style.display = "block";
        }
        else {
            this.startMenu.style.display = "block";
            this.desktopPane.style.display = "none";
        }
        this.Showing = !this.Showing;
    }
}
let StartMenuHandler = new StartMenu();
