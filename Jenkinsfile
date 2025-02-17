pipeline {
    agent any

    environment {
        GIT_REPO = 'https://github.com/AnassJarrah/MyWebApi.git'
    }

    stages {
        stage('Checkout') {
            steps {
                script {
                    // Checkout from Git repository explicitly using 'main' branch
                    checkout([
                        $class: 'GitSCM', 
                        branches: [[name: 'refs/heads/main']], 
                        userRemoteConfigs: [[url: 'https://github.com/AnassJarrah/MyWebApi.git']]
                    ])
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    // Build the project (assuming a .NET application)
                    bat 'dotnet build MyWebApi.sln'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    // Run tests (replace with your actual test command)
                    bat 'dotnet test'
                }
            }
        }

        stage('Publish') {
            steps {
                script {
                    // Publish the app (replace with your actual publish command)
                    bat 'dotnet publish -c Release -o ./publish'
                }
            }
        }

        stage('Deploy') {
            steps {
                script {
                    // Deploy (replace with your actual deploy steps)
                    echo 'Deploying application'
                }
            }
        }
    }

    post {
        always {
            cleanWs()
        }
        success {
            echo 'Pipeline succeeded!'
        }
        failure {
            echo 'Pipeline failed!'
        }
    }
}

