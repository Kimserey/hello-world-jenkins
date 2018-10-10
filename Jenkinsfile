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
				sh "cd src/HelloWorldJenkins && dotnet build"
			}
        }

        stage('test') {
			steps {
				sh "cd src/HelloWorldJenkins.UnitTests && dotnet test"
			}
        }
    }
}