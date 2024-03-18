function solve(grade) {
    
    let result = formatGrade(grade);
    
    function formatGrade(grade){
        let result;
        
        if (grade < 3){
            result = `Fail (${Math.floor(grade)})`;
            return result;
        } else if (grade < 3.50){
            result = `Poor (${grade.toFixed(2)})`;
            return result;
        } else if (grade < 4.50){
            result = `Good (${grade.toFixed(2)})`;
            return result;
        } else if (grade < 5.50){
            result = `Very good (${grade.toFixed(2)})`;
            return result;
        } else if (grade >= 5.50){
            result = `Excellent (${grade.toFixed(2)})`;
            return result;
        }
            
    }

    console.log(result);
}


solve(3.33);
solve(4.50);
solve(2.99);