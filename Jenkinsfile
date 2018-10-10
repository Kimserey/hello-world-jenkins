pipeline {
    agent any

	parameters {
        string(name: 'CommitId', description: 'Commit ID to checkout')
    }

	options {
		skipDefaultCheckout true
	}

	stages {
        stage('checkout') {
            steps {
                checkout scm
				checkout([
					$class: 'GitSCM',
					branches: [[name: params.CommitId ],
					userRemoteConfigs: [[url: 'https://github.com/Kimserey/hello-world-jenkins.git' ]]])
            }
        }

        stage('build') {
			steps {
				withCredentials([string(credentialsId: 'mysecret', variable: 'SECRET')]) {
					sh """
						set +x
						echo $SECRET
					"""
				}

				sh "dotnet build src/HelloWorldJenkins"
			}
        }

        stage('test') {
			steps {
				sh "dotnet test test/HelloWorldJenkins.UnitTests"
			}
        }
    }
}