# Git & Github

## Commandline commands

Git version controll download site: https://git-scm.com

### To display git version

\>git --version

### Show current status

\>git status

### Show log

\>git log

### Global configuration of user information used at sign in on github

\>git config --global user.name "Your usernam on github"\
\>git config --global user.email "Your email"\
\>git config --global user.password "Your password on github"\

List all configurations\
git config --list

List all configurations and their origins\
\> git config --list --show-origin

### Initializing a new git project/folder

\>git init

### Add files to track, all new files must be added so they can be tracked

\>git add <file1name.xxx>, <file2name.xxx> _(list of individual files)_
\>git add . _(adds all)_

### Commit files and changes

\>git commit -m "Comment describing the changes and/or additions" _(needs a \">git add <file.xxx> or .\" before commit command.)_
\>git commit -am "Comments as above" _(if all files are already tracked then this will commit changes without having to do a \">git add\" command first.)_

### Checking the changes in a file

\>git diff <file1name.xxx>

## Git Branches

### View branches

\>git branch _(Lists all branches, active branch denoted with an asterix)_

### Creat new branch

\>git branch \<nameOfBranch>
\>git checkout -b \<nameOfBranch> _(switches to nameOfBranch branch, if it doesn't exists it will be created)_

### Switch to branch ...

\>git checkout \<nameOfBranch>

### View changes in last commit

\>git show

### View changes in a particular commit

\>git show \<commitId>
Example:
\>git show c26fc3019a662c46f61d6c5fc9c59d1be1ecefb9 _(commit id can be found in \">git log\")_

### Merge branches locally

1. Change to the branch you want to merge into (>git checkout \<branchName>)
2. Merge otherBranch into current branch (>git merge \<theOtherBranchName>)
   this creates a merge commit.

## Handle remote connections

### View existing remote connection names

\>git remote _(lists existing remotes)_

### View existing remote information

\>git remote -v

### Add a new remote

\>git remote add \<nameOfRemote> \<remoteURL> _(remoteURL used for push and fetch(pull))_

### Remove remote connection

\>git remote remove \<nameOfRemote>
or equivalent
\>git remote rm \<nameOfRemote>

... more content to follow.
