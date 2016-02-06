git init
git remote add library https://github.com/gustavo-vasquez/LibraryProyect.git
git status
git add .
git commit -m "Version inicial de la biblioteca"
git push library master
git fetch library master
git merge master
git pull library master
git config core.askpass ''
git push library master:master
git checkout -b initial
git push library initial
git checkout master
exit
