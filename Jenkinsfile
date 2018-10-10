pipeline {
    agent any

	options {
		skipDefaultCheckout true
	}

	stages {
        stage('checkout') {
            steps {
                checkout scm
            }
        }

        stage('build') {
			steps {
				sh "cd src && dotnet build"
			}
        }

        stage('test') {
			steps {
				sh "cd test && dotnet test"
			}
        }
    }
}