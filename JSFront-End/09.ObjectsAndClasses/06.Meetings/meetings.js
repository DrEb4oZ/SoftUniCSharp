function solve(input) {
    let meetings = {};
    for (let i = 0; i < input.length; i++) {
        let [property, value] = input[i].split(' ');
        if (!meetings.hasOwnProperty(property)){
            meetings[property] = value;   
            console.log(`Scheduled for ${property}`);
        } else{
            console.log(`Conflict on ${property}!`);
        }
        
    }

    for (const meeting in meetings) {
        console.log(`${meeting} -> ${meetings[meeting]}`);
    }
}



solve(['Monday Peter',
'Wednesday Bill',
'Monday Tim',
'Friday Tim']
)