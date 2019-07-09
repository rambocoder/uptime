rm -rf .wercker/ #_build _steps _projects
wercker build --git-domain github.com --git-owner rambocoder --git-repository uptime
rm -rf .wercker/