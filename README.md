# Pokémart Auto Redeemer
This package contains the source for an application you can use to insert Pokémon Trading Card Game Online (PTCGO) codes automatically. 

The source requires Visual Studio 2019 Preview and .NET Core 3.1 to open/use.

On the 'release' page I've provided you with versions of the application:
* The 'self-contained' version. This version includes all the external prerequisites in order to run the application (in this case .NET Core 3.1).
* The 'framework-dependent' version. This is the application only. Upon opening the application you will be prompted to install the prerequisites.

# Instructions

### 1. Monitor selection
![Step 1 image](https://raw.githubusercontent.com/Auriorx/pokemart-auto-redeemer/master/images/step1.png)

On this page you can choose which display you want to use for the automatic code redeeming. The primary monitor is selected by default. 

:warning: Please note that at this time, the following screen resolutions are supported:

* 2560x1440
* 1920x1200
* 1920x1080

I'm happy to add support for more resolutions on-demand. :)

### 2. Paste codes
![Step 2 image](https://raw.githubusercontent.com/Auriorx/pokemart-auto-redeemer/master/images/step2.png)

On this page you can paste the PTCGO codes. Please make sure that you have 1 code per line.

### 3. Preparation
![Step 3 image](https://raw.githubusercontent.com/Auriorx/pokemart-auto-redeemer/master/images/step3.png)

This page is self explanatory. It contains information on how to prepare for the automatic code redeeming.

### 4. Let's Go!
![Step 4 image](https://raw.githubusercontent.com/Auriorx/pokemart-auto-redeemer/master/images/step4.png)

Some more usefull information and a progress bar to show you... Well, the progress. If this application has helped you out, please don't hesitate to donate a small amount of pokébucks to yours truly. :)

[Donate here :)](https://donorbox.org/auriorx)

### Useful Information
* Please note that the progress bar will only be visible for people who have two or more screens and have the application running on a different monitor than where PTCGO is running.
* If you only have one monitor, the application will hide itself while redeeming the PTCGO codes.
* Due to a bad internet connection and/or a poorly available PTCGO server, the program might run faster than that the buttons on screen appear. Press the **Escape** key, to stop the redeeming at any time.
* This application can not tell the difference between a valid or an invalid PTCGO code. With big batches, please ensure that at least one out of every 10 PTCGO code card is valid. If not, the application will not be able to continue with inserting codes.
* Please understand that this is an application that simulates clicks on your screen. I am not responsible for wrong clicks on your screen.

# Issues and future functionality.
Please submit any issue you have with the application in this repo. I'd be happy to fix them as soon as possible. 

I'm also considering to create a tool that can convert the QR codes present on your display to the actual code automatically. This way you could make pictures of physical codes, open them on your desktop and automatically get a code list, which you can then paste in this application. If you would like for me to make such an application, please leave a thumbs up on [the following issue](https://github.com/Auriorx/pokemart-auto-redeemer/issues/1).

