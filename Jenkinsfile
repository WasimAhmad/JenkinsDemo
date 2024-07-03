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
        stage('Archive') {
            steps {
                archiveArtifacts artifacts: 'JenkinsDemo/bin/Release/*.exe', allowEmptyArchive: true
            }
        }
    }
}
