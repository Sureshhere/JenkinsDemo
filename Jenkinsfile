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
                bat 'dotnet test --configuration Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish JenkinsDemo/JenkinsDemo.csproj --configuration Release --no-build -o publish'
            }
        }
    }
}