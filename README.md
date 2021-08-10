# Urek's Picture-Toolbox ![GitHub all releases](https://img.shields.io/github/downloads/UrekD/Picture-Toolbox/total?style=for-the-badge) ![GitHub repo size](https://img.shields.io/github/repo-size/UrekD/Picture-Toolbox?style=for-the-badge) ![GitHub last commit](https://img.shields.io/github/last-commit/UrekD/Picture-Toolbox?style=for-the-badge)
Simple .Net app for compressing and resizing PNG and JPG images using the Tinify API on directory level

This was made mainly for my personal usage and for now it fulfills all the demands so more development is not expected, the app is fairly simple and can be modified and build easily with using MS Visual Studio. Unlike the others this will overwrite the originals by default for free and uses FileDialog method a like to browse directories, which is much better than DirectoryDialog.

Possible future updates:
- [x] Save and load prev selected settings and API key
- [ ] Easy way to change the API key
- [ ] Option for local resize without API
- [ ] Scale resize type
- [ ] Option to include subdirectories
- [ ] Option to not overwritte original photos
- [ ] App logs
- [ ] Code Refactor

<p align="center">
  <img  src="https://user-images.githubusercontent.com/38784343/128934122-9a353be1-6b37-4880-b322-502ebee830ce.gif" />
</p>

# **Usage**
1. Get API key from https://tinify.com/dashboard/api, insert and validate it in the app.
2. Select the directory you wish to compress, does not effect subdirectories at the moment.
3. Tick if you wish to resize, and chose the type and size
4. Click Start
5. Wait...
6. Profit

**Original images will get overwritten!!**

# **Changing API**

Free tier limits to 500 API calls, resize and compress are each 1 call, so if you compress and resize you used 2 operations.
Ways to change API key atm...:
1. Deactivate the one currectly saved
2. Delete C:\Users\(Your Username)\AppData\Local\UrekD_@GitHub
3. Manually edit the config found in the directory written above.

# **If this helps consider starring the repo**
Feel free to use this in your own project or contribute to advance this repo. If you have any concers or wish to contact me you can do this on Discord Urek#2576, via email listed on my profile or using repo tools such as issues etc.
