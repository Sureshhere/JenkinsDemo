pipeline {
    agent any

    stages {

        stage('Restore') {
            steps { bat 'dotnet restore' }
        }

        stage('Build') {
            steps { bat 'dotnet build -c Release' }
        }

        stage('Test') {
            steps {
                bat 'dotnet test -c Release --logger "trx;LogFileName=test_results.trx"'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish JenkinsDemo/JenkinsDemo.csproj -c Release -o publish'
            }
        }
    }

    post {
        always {
            junit allowEmptyResults: true, testResults: '**/*.trx'
        }
    }
}