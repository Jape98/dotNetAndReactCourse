import { Link } from "react-router-dom";
import { Button, Header, Segment } from "semantic-ui-react";

export default function NotFound() {

    return(
        <Segment placeholder>
            <Header icon>
                Oops- we've looked everywhere and could not find this.
            </Header>
            <Segment.Inline>
                <Button as={Link} to='/activities'>Return to activities page</Button>
            </Segment.Inline>
        </Segment>
    )
}