printf "\033[47;30m\n"
while read -r line ; do
    mono Program.exe $line
done < $1

