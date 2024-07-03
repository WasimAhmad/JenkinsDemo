pipeline {
agent { label 'win-agent' } 
    triggers {
        githubPush()
    }
    stages {
        stage('Build') {
            steps {
                script {
                    bat 'MSBuild.exe JenkinsDemo.sln /p:Configuration=Release'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    bat '"C:\\Program Files\\Microsoft Visual Studio\\2022\\Enterprise\\Common7\\IDE\\CommonExtensions\\Microsoft\\TestWindow\\vstest.console.exe" JenkinsDemo.Tests\\bin\\Release\\JenkinsDemo.Tests.dll'
                }
            }
        }
        stage('Archive') {
            steps {
                archiveArtifacts artifacts: 'JenkinsDemo/bin/Release/*.exe', allowEmptyArchive: true
            }
        }
    }
}
