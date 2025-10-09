# Install Trivy

## MacOS/Linux Install
brew update
brew install trivy
trivy --version

## Windows Install
https://github.com/aquasecurity/trivy/releases/

Extract zip folder to a folder of your choosing (`E.g C:\Program Files\Trivy`)

Add the same path where your files were extracted too to your Environment variables.

1. Click Win+R
2. Write `SystemPropertiesAdvanced`
3. Click on `Environment Variables`
4. Click on `System variables` and find the `Path` variable.
5. Paste the address to where you installed Trivy.

Restart your pc for the Environment variables to take effect:

In VSCode, CMD or Powershell, run the following command to verify the installation was successful:
```bash
trivy --version
$ Version: 0.65.0
```

# Check for vulnerabilities in your project
Open up any project in VSCode.

Open a terminal in VSCode.

Type 
```bash
trivy fs --scanners vuln,misconfig,secret,license --severity UNKNOWN,LOW,MEDIUM,HIGH,CRITICAL --ignore-unfixed=false --format table .
```

For textfile output, type:

```bash
trivy fs --scanners vuln,misconfig,secret,license --severity UNKNOWN,LOW,MEDIUM,HIGH,CRITICAL --ignore-unfixed=false --format sarif -o trivy.sarif .
```