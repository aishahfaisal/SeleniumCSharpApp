# SeleniumCSharpApp

### Develop a Selenium automation test to validate the following:
1. Navigate to https://www.amazon.com/
2. Type in “laptop” in the search text box
3. Click on “Search” button
4. Click on the first result
5. Upon page loaded, assert that the laptop price is more than $100.

### Implementation Requirements:
1. Using C# project in Visual Studio - done
2. Using Selenium Web Driver (Chrome or Microsoft Edge) - done
3. Assume web driver is located at C:\Driver\ - TBC
4. Test should be able to execute upon hitting F5 - done
5. Test should be completed in less than 30 seconds - done

### Delivery:
1. Source code that has been tested and is ready to be compiled and executed. Visual Studio project in ZIP (including bin, obj and packages folder).
2. Any manual step in setting up should be scripted in an automated manner. (With tools like NodeJS, PowerShell, Visual Studio project file).
3. Please deliver this in a publicly available repository like GitHub, BitBucket etc. With documentation about your concerns, decisions, guiding and testing etc.

### Set up:
Pre-conditions:
1. Device used: Mac.
2. Has no Homebrew installed.
3. Has no Visual Studio installed.

Steps:
1. Open terminal at folder contain file "install_visual_studio.sh".
2. Run command "./install_visual_studio.sh".

### Concerns / Decisions:
1. The code has been developed and tested on Mac M1. Considering point number 3 on Implementation Requirements, may need to make adjustments to the code or configuration based on the differences, to ensure the code works correctly on all platforms.
2. The headless mode is implemented to reduce the time of execution and minimize human interaction in the test. However, there may be times you want to mimic a real user or visually see the test run hence running the test in a non-headless mode will be recommended. For the scope of this test, the time difference should not be more than 5 seconds.
