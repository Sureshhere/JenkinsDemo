pipeline {
    agent any

    stages {

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish JenkinsDemo/JenkinsDemo.csproj -c Release -o publish --no-build'
            }
        }
    }
}