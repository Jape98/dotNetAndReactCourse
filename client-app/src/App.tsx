import './App.css';
import React from 'react'
import axios from 'axios';
//import 'semantic-ui-css/semantic.min.css' //Does not work for some odd reason.
import { Header, List } from 'semantic-ui-react';
import { useEffect, useState } from "react";

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then(response =>{
      console.log(response);
      setActivities(response.data);
    })
  }, [])

  return (
    <div>
      <Header as='h1' icon='users' content='reactivities'/>
      <List>
      {activities.map((activity :any) => (
            <li key={activity.id}>
              {activity.title}
            </li>
          ))}
      </List>
    </div>
  );
}

export default App;
