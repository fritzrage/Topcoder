class Time:      
    def whatTime(self,seconds):    
        while (seconds <= 24 * 60 * 60 - 1):             
            minutes = seconds // 60
            remaining_seconds = seconds % 60
            hours = minutes // 60
            remaining_minutes = minutes % 60
            LocalTime = str(hours) + ":" + str(remaining_minutes) + ":" + str(remaining_seconds)
            return LocalTime        
        return "0:0:0"
