pipeline {
    agent any
    
    environment {
        DOTNET_CLI_HOME = '/tmp' // Spécifie un répertoire temporaire pour les outils .NET
    }
    
    stages {
        stage('Checkout') {
            steps {
                // Récupère le code depuis le dépôt Git
                git 'https://github.com/AnassJarrah/MyWebApi.git' // Remplace par l'URL de ton dépôt
            }
        }
        
        stage('Restore') {
            steps {
                // Restaure les dépendances du projet .NET
                script {
                    sh 'dotnet restore MyWebApi.sln'
                }
            }
        }
        
        stage('Build') {
            steps {
                // Compile le projet en mode Release
                script {
                    sh 'dotnet build MyWebApi.sln --configuration Release'
                }
            }
        }
        
        stage('Test') {
            steps {
                // Exécute les tests unitaires (assurez-vous que xUnit et autres dépendances sont installées)
                script {
                    sh 'dotnet test MyWebApi.Tests/MyWebApi.Tests.csproj --configuration Release'
                }
            }
        }
        
        stage('Publish') {
            steps {
                // Publie l'artefact si nécessaire (par exemple, un fichier .zip ou un fichier de déploiement)
                script {
                    sh 'dotnet publish MyWebApi/MyWebApi.csproj --configuration Release --output ./publish'
                }
            }
        }
        
        stage('Deploy') {
            steps {
                // Déployer le projet, peut-être en utilisant un serveur ou un service de cloud
                script {
                    // Commande de déploiement ici (par exemple vers Azure, AWS, ou tout autre service)
                    echo 'Déploiement en cours...'
                }
            }
        }
    }
    
    post {
        always {
            // Actions qui doivent être exécutées après chaque pipeline
            cleanWs() // Nettoie l'espace de travail
        }
        
        success {
            // Actions en cas de succès
            echo 'Le pipeline a réussi !'
        }
        
        failure {
            // Actions en cas d'échec
            echo 'Le pipeline a échoué.'
        }
    }
}

