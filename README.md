# Shell-Scripts
A few bash scripts that make my life easier in my Linux environments. Many of these are trivial, but I use them often enough 
that they make a big difference. I also made them for the experience of learning bash and for my own entertainment.

Current scripts:
1. `back`: Same functionality as `cd ..`, but you can choose how many directories to go up by (e.g. `back 2` = `cd ../..`)
2. `cv`: Combines cd and mv into one command. Currently a work in progress.
3. `fs`: Fixes a strange issue with my mouse's scrolling being inverted whenever I plug it in using `xinput` (fs = fix scrolling)
4. `mountseas`: Mount the remote school Linux server to my machine. Enables access to server files via GUI file explorer
5. `sshseas`: SSH into the remote school Linux server with a much shorter command
6. `scpseas`: scp a file to the remote school Linux server without typing it out
6. `resize`: Resize my terminal window to 80x43 without having to use my mouse
7. `rmspace`: Removes all spaces from all filenames in a directory. This was more of a one-time issue I had, but you never know when it'll happen again.
8. `backup`: Back up my `~/Documents` directory. This script is run daily with `cron`/`anacron`, and backs up my files by tarring the directory and uploading that `tar.gz` file into my Google Drive.
