P1: Since we are pushing from the master branch, it is loaded onto the github into the master branch, respectively. Moreover, the master branch is the main branch.

P2: When we compare with the unloaded version, we are shown two versions of the code before and after the change, which are indicated by color and thick places.

P3: No changes are made in the remote repository, because when we try to push, it gives us an error due to the inconsistency of files in the local and remote repositories.

P4: Commit all will not commit changes to your remote repository, it will only commit changes to your local repository. In git: git commit -a.

P5: Commit all and Push do the same as just commit all, but they also immediately upload changes to the remote repository. In git: git add.

P6: Commit and Sync does three things. First, it will commit. Second, it will perform a pull (grabs the updated information from the remote repo). Finally, it will push. In git: git push origin master.

P7: Pull is unidirectional data-transfer (from remote to local), Sync (as it written) is bidirectional (pull+push) and publish local changes into remote. In git: git pull.
