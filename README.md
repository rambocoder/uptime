# uptime

You can find the docker image for this project [here](https://hub.docker.com/r/rambocoder/uptime/tags/).

# Build Status

## Wercker

[![wercker status](https://app.wercker.com/status/ea01e6d091c0a5d70eb4fa591d219c19/s/master "wercker status")](https://app.wercker.com/project/byKey/ea01e6d091c0a5d70eb4fa591d219c19)

Builds the code, creates a docker container and pushes it to DockerHub

## Azure DevOps Pipeline

[![Build Status](https://dev.azure.com/azure8/uptime/_apis/build/status/rambocoder.uptime?branchName=master)](https://dev.azure.com/azure8/uptime/_build/latest?definitionId=1&branchName=master)

## Docker File

`
docker pull rambocoder/uptime
docker run -p 8080:8080 rambocoder/uptime
docker ps
docker kill
`

## Additional information

[(Continuous Integration common practices)](https://en.wikipedia.org/wiki/Continuous_integration#Common_practices)
[(Building Microservices with ASP.NET Core)](https://learning.oreilly.com/library/view/building-microservices-with/9781491961728/ch02.html)